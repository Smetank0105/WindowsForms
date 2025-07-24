using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace WindowsForms
{
	public partial class MainForm : Form
	{
		ChooseFont chooseFont;
		ColorDialog cdBackColor;
		ColorDialog cdForeColor;

		bool lbl_mouse_press = false;
		Point cursorStartPoint;
		Point lblStartPoint;
		public MainForm()
		{
			InitializeComponent();
			ShowControls(cmShowControls.Checked);
			//ShowConsole(cmDebugConsole.Checked = true);
			chooseFont = new ChooseFont();
			cdBackColor = new ColorDialog();
			cdForeColor = new ColorDialog();
		}
		void ShowControls(bool visible)
		{
			cbShowDate.Visible = visible;
			cbShowWeekDay.Visible = visible;
			btnHideControls.Visible = visible;
			this.ShowInTaskbar = visible;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
			//this.labelCurrentTime.BackColor = visible ? this.BackColor : Color.DeepSkyBlue;
		}
		void ShowConsole(bool visible)
		{
			if (visible) AllocConsole();
			else FreeConsole();
		}
		private void timer_Tick(object sender, EventArgs e)
		{
			labelCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
			if (cbShowDate.Checked)
				labelCurrentTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
			if (cbShowWeekDay.Checked)
				labelCurrentTime.Text += $"\n{DateTime.Now.DayOfWeek}";
			notifyIcon.Text = labelCurrentTime.Text;
		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{
			ShowControls(cmShowControls.Checked = false);
		}

		private void labelCurrentTime_DoubleClick(object sender, EventArgs e)
		{
			ShowControls(cmShowControls.Checked = true);
		}

		private void cmClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cmTopmost_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = cmTopmost.Checked;
		}

		private void cmShowControls_CheckedChanged(object sender, EventArgs e)
		{
			ShowControls(cmShowControls.Checked);
		}
		private void cmDebugConsole_CheckedChanged(object sender, EventArgs e)
		{
			ShowConsole(cmDebugConsole.Checked);
		}
		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		public static extern bool FreeConsole();
		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			if (this.TopMost) return;
			this.TopMost = true;
			this.TopMost = false;
		}

		private void cmShowDate_CheckedChanged(object sender, EventArgs e)
		{
			cbShowDate.Checked = cmShowDate.Checked;
		}

		private void cmShowWeekDay_CheckedChanged(object sender, EventArgs e)
		{
			cbShowWeekDay.Checked = cmShowDate.Checked;
		}
		private void cbShowDate_CheckedChanged(object sender, EventArgs e)
		{
			cmShowDate.Checked = cbShowDate.Checked;
		}

		private void cbShowWeekDay_CheckedChanged(object sender, EventArgs e)
		{
			cmShowWeekDay.Checked = cbShowWeekDay.Checked;
		}

		private void cmBackColor_Click(object sender, EventArgs e)
		{
			if (cdBackColor.ShowDialog() != DialogResult.Cancel)
				labelCurrentTime.BackColor = cdBackColor.Color;
		}

		private void cmForeColor_Click(object sender, EventArgs e)
		{
			if (cdForeColor.ShowDialog() != DialogResult.Cancel)
				labelCurrentTime.ForeColor = cdForeColor.Color;
		}

		private void cmFont_Click(object sender, EventArgs e)
		{
			chooseFont.ShowDialog();
			labelCurrentTime.Font = chooseFont.Font;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			cmTopmost.Checked = Properties.Settings.Default.TopMost;
			cmShowDate.Checked = Properties.Settings.Default.ShowDate;
			cmShowWeekDay.Checked = Properties.Settings.Default.ShowWeekDay;
			this.Location = Properties.Settings.Default.StartPosition;
			labelCurrentTime.BackColor = Properties.Settings.Default.BackColor;
			labelCurrentTime.ForeColor = Properties.Settings.Default.ForeColor;
			labelCurrentTime.Font = Properties.Settings.Default.Font;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.TopMost = this.TopMost;
			Properties.Settings.Default.ShowDate = cbShowDate.Checked;
			Properties.Settings.Default.ShowWeekDay = cbShowWeekDay.Checked;
			Properties.Settings.Default.StartPosition = this.Location;
			Properties.Settings.Default.BackColor = labelCurrentTime.BackColor;
			Properties.Settings.Default.ForeColor = labelCurrentTime.ForeColor;
			Properties.Settings.Default.Font = labelCurrentTime.Font;
			Properties.Settings.Default.Save();
		}

		private void labelCurrentTime_MouseDown(object sender, MouseEventArgs e)
		{
			lbl_mouse_press = true;
			cursorStartPoint = Cursor.Position;
			lblStartPoint = this.Location;
		}

		private void labelCurrentTime_MouseMove(object sender, MouseEventArgs e)
		{
			if(lbl_mouse_press)
			{
				Point cursorOffsetPoint = new Point(Cursor.Position.X - cursorStartPoint.X, Cursor.Position.Y - cursorStartPoint.Y);
				this.Location = new Point(lblStartPoint.X + cursorOffsetPoint.X, lblStartPoint.Y + cursorOffsetPoint.Y);
			}
		}

		private void labelCurrentTime_MouseUp(object sender, MouseEventArgs e)
		{
			lbl_mouse_press = false;
			cursorStartPoint = Point.Empty;
		}

	}
}
