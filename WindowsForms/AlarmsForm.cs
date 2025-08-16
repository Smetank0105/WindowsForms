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

namespace WindowsForms
{
	public partial class AlarmsForm : Form
	{
		ChooseSound chooseSound;
		SoundPlayer sp;
		public List<DateTime> alarmsList;
		public AlarmsForm()
		{
			InitializeComponent();
			chooseSound = new ChooseSound();
			sp = new SoundPlayer(Properties.Resources.sound);
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
				sp.PlayLooping();
				DialogResult result = MessageBox.Show("Turn off the Alarm!", "Alarm", MessageBoxButtons.OK);
				if (result == DialogResult.OK) sp.Stop();
			}
		}
	}
}
