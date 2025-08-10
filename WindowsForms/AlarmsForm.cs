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
		public List<DateTime> alarmsList;
		public AlarmsForm()
		{
			InitializeComponent();
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
	}
}
