using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsForms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			labelCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
			if (checkBoxDate.CheckState == CheckState.Checked) labelCurrentDate.Text = DateTime.Now.ToString("D");
			else labelCurrentDate.Text = "";
			if (checkBoxDay.CheckState == CheckState.Checked) labelCurrentDay.Text = DateTime.Now.ToString("dddd");
			else labelCurrentDay.Text = "";
		}
	}
}
