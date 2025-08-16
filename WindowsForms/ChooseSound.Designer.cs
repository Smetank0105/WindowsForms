
namespace WindowsForms
{
	partial class ChooseSound
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBoxChooseSound = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// comboBoxChooseSound
			// 
			this.comboBoxChooseSound.FormattingEnabled = true;
			this.comboBoxChooseSound.Location = new System.Drawing.Point(16, 13);
			this.comboBoxChooseSound.Name = "comboBoxChooseSound";
			this.comboBoxChooseSound.Size = new System.Drawing.Size(394, 21);
			this.comboBoxChooseSound.TabIndex = 0;
			// 
			// ChooseSound
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comboBoxChooseSound);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ChooseSound";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ChooseSound";
			this.TopMost = true;
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxChooseSound;
	}
}