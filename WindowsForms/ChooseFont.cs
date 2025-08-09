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
using System.Drawing.Text;

namespace WindowsForms
{
	public partial class ChooseFont : Form
	{
		public Font Font { get; set; }
		public string Filename { get; set; }
		PrivateFontCollection pfc;
		public ChooseFont()
		{
			InitializeComponent();
			comboBoxChooseFont.Items.AddRange(GetFontListFromCurrentDirectoryByExtention("*.ttf"));
			comboBoxChooseFont.Items.AddRange(GetFontListFromCurrentDirectoryByExtention("*.otf"));
			comboBoxChooseFont.SelectedIndex = 0;
		}
		public ChooseFont(MainForm parent, string font_name, int font_size):this()
		{
			nudFontSize.Value = font_size;
			comboBoxChooseFont.SelectedIndex = comboBoxChooseFont.FindStringExact(font_name);
			Font = lblExample.Font;
			Filename = font_name;
		}
		string[] GetFontListFromCurrentDirectoryByExtention(string extention)
		{
			string execution_path = Path.GetDirectoryName(Application.ExecutablePath);
			Directory.SetCurrentDirectory($"{execution_path}\\..\\..\\Fonts");
			string[] fonts = Directory.GetFiles(Directory.GetCurrentDirectory(), extention);
			for(int i=0;i<fonts.Length;i++)
			{
				fonts[i] = fonts[i].Split('\\').Last();
			}
			return fonts;
		}
		void SetFont(string filename, float size = 32)
		{
			pfc = new PrivateFontCollection();
			pfc.AddFontFile(filename);
			lblExample.Font = new Font(pfc.Families[0], size);
		}

		private void comboBoxChooseFont_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((sender as ComboBox).SelectedItem != null) SetFont((sender as ComboBox).SelectedItem.ToString());
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Font = lblExample.Font;
			Filename = comboBoxChooseFont.SelectedItem.ToString();
		}

		private void nudFontSize_ValueChanged(object sender, EventArgs e)
		{
			SetFont(comboBoxChooseFont.SelectedItem.ToString(), (float)nudFontSize.Value);
		}
	}
}
