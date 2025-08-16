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
		public ChooseSound()
		{
			InitializeComponent();
			comboBoxChooseSound.Items.AddRange(GetListFromDirectory());
		}
		string[] GetListFromDirectory()
		{
			string execution_path = Path.GetDirectoryName(Application.ExecutablePath);
			Directory.SetCurrentDirectory($"{execution_path}\\..\\..\\Sounds");
			string[] sounds = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.wav");
			for (int i = 0; i < sounds.Length; i++)
				sounds[i] = sounds[i].Split('\\').Last();
			return sounds;
		}
	}
}
