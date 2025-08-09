using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
	public partial class AlarmsForm : Form
	{
		List<string> alarmsList;
		public AlarmsForm()
		{
			InitializeComponent();
			alarmsList = new List<string>();
		}

		private void btnAlarmsFormAdd_Click(object sender, EventArgs e)
		{
			alarmsList.Add(dtpAlarmsForm.Text);
			alarmsList.Sort();
			lbAlarmsForm.Items.Clear();
			foreach(var item in alarmsList)
			{
				lbAlarmsForm.Items.Add(item);
			}
		}
	}
}
