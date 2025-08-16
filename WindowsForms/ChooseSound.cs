using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace WindowsForms
{
	public partial class ChooseSound : Form
	{
		SoundPlayer spExample { get; set; }
		public SoundPlayer sp { get; set; }
		public string sound_path { get; set; }
		bool soundExampleFlag = false;
		public ChooseSound()
		{
			InitializeComponent();
			string[] sound_list = GetListFromDirectory();
			for (int i = 0; i < sound_list.Length; i++)
				sound_list[i] = sound_list[i].Split('\\').Last();
			comboBoxChooseSound.Items.AddRange(sound_list);
			comboBoxChooseSound.SelectedIndex = comboBoxChooseSound.FindStringExact(Properties.Settings.Default.AlarmSound.Split('\\').Last());
		}
		string[] GetListFromDirectory()
		{
			string execution_path = Path.GetDirectoryName(Application.ExecutablePath);
			Directory.SetCurrentDirectory($"{execution_path}\\..\\..\\Sounds");
			string[] sounds = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.wav");
			return sounds;
		}
		void SetSound(string sound_path)
		{
			spExample = new SoundPlayer(sound_path);
		}

		private void comboBoxChooseSound_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((sender as ComboBox).SelectedItem != null) SetSound(GetListFromDirectory()[(sender as ComboBox).SelectedIndex]);
		}

		private void btnChooseSoundOK_Click(object sender, EventArgs e)
		{
			sp = spExample;
			sound_path = GetListFromDirectory()[comboBoxChooseSound.SelectedIndex];
		}

		private void btnPlayStop_Click(object sender, EventArgs e)
		{
			if(!soundExampleFlag)
			{
				btnPlayStop.Text = "STOP";
				spExample.PlayLooping();
				soundExampleFlag = true;
			}
			else
			{
				btnPlayStop.Text = "PLAY";
				spExample.Stop();
				soundExampleFlag = false;
			}
		}
	}
}
