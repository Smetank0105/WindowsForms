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
	public partial class TimerForm : Form
	{
		bool timerFlag = false;
		DateTime startTime;
		DateTime currentTime;
		SoundPlayer sp;
		public TimerForm()
		{
			InitializeComponent();
			mtbTimer.ValidatingType = typeof(DateTime);
			sp = new SoundPlayer(Properties.Resources.sound);
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			TimeSpan ticks = DateTime.Now - startTime;
			if ((lblTimer.Text = (currentTime - ticks).ToString("HH:mm:ss")) == "00:00:00")
			{
				timer.Stop();
				sp.PlayLooping();
				lblTimer.Text = "ALARM!!!";
				if (!this.Visible) this.ShowDialog();
			}
		}

		private void btnStartStopTimer_Click(object sender, EventArgs e)
		{
			if(!timerFlag)
			{
				if (DateTime.TryParse(mtbTimer.Text, out currentTime))
				{
					startTime = DateTime.Now;
					timer.Start();
					mtbTimer.Visible = false;
					lblTimer.Visible = true;
					btnStartStopTimer.Text = " STOP";
					timerFlag = true; 
				}
			}
			else
			{
				timer.Stop();
				sp.Stop();
				mtbTimer.Text = lblTimer.Text;
				mtbTimer.Visible = true;
				lblTimer.Visible = false;
				btnStartStopTimer.Text = "START";
				timerFlag = false;
			}
		}
	}
}
