using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace WindowsForms
{
	public partial class AlarmsForm : Form
	{
		ChooseSound chooseSound;
		public List<DateTime> alarmsList;
		public AlarmsForm()
		{
			InitializeComponent();
			chooseSound = new ChooseSound();
			alarmsList = new List<DateTime>();
			ShowList();
		}
		public void ShowList()
		{
			lbAlarmsForm.Items.Clear();
			if (alarmsList.Count > 0)
			{
				foreach (var item in alarmsList)
				{
					lbAlarmsForm.Items.Add(item);
				} 
			}
		}
		private void btnAlarmsFormAdd_Click(object sender, EventArgs e)
		{
			alarmsList.Add(dtpAlarmsForm.Value);
			alarmsList.Sort();
			ShowList();
		}

		private void lbAlarmsForm_DoubleClick(object sender, EventArgs e)
		{
			if (lbAlarmsForm.Items.Count > 0)
			{
				alarmsList.RemoveAt(lbAlarmsForm.SelectedIndex);
				lbAlarmsForm.Items.RemoveAt(lbAlarmsForm.SelectedIndex); 
			}
		}

		private void btnAlarmsFormSound_Click(object sender, EventArgs e)
		{
			chooseSound.ShowDialog();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (alarmsList.Count > 0 && alarmsList[0] <= DateTime.Now)
			{
				alarmsList.RemoveAt(0);
				ShowList();
				chooseSound.sp.PlayLooping();
				DialogResult result = MessageBox.Show("Turn off the Alarm!", "Alarm", MessageBoxButtons.OK);
				if (result == DialogResult.OK) chooseSound.sp.Stop();
			}
		}

		private void AlarmsForm_Load(object sender, EventArgs e)
		{
			if (File.Exists(Properties.Settings.Default.AlarmSound))
			{
				chooseSound.sound_path = Properties.Settings.Default.AlarmSound;
				chooseSound.sp = new SoundPlayer(chooseSound.sound_path);
			}
			else
				chooseSound.sp = new SoundPlayer(Properties.Resources.sound);
		}

		private void AlarmsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.AlarmSound = chooseSound.sound_path;
			Properties.Settings.Default.Save();
		}
	}
}
