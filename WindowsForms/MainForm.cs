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
using System.Drawing.Text;

namespace WindowsForms
{
	public partial class MainForm : Form
	{
		private PrivateFontCollection fontCollection;
		public MainForm()
		{
			InitializeComponent();
			ShowControls(cmShowControls.Checked);

			string[] asFontList;
			if (Directory.Exists("Fonts"))
			{
				fontCollection = new PrivateFontCollection();
				asFontList = Directory.GetFiles("Fonts");
				foreach (string item in asFontList)
				{
					cmFont.DropDownItems.Add(item);
					fontCollection.AddFontFile(item);
				}
			}
		}
		void ShowControls(bool visible)
		{
			cbShowDate.Visible = visible;
			cbShowWeekDay.Visible = visible;
			btnHideControls.Visible = visible;
			this.ShowInTaskbar = visible;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedDialog : FormBorderStyle.None;
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

		private void cmFont_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			labelCurrentTime.Font = new Font(fontCollection.Families[cmFont.DropDownItems.IndexOf(e.ClickedItem)], 32);
		}
	}
}
