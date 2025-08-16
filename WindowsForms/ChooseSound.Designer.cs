
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
			this.btnPlayStop = new System.Windows.Forms.Button();
			this.btnChooseSoundOK = new System.Windows.Forms.Button();
			this.btnChooseSoundCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBoxChooseSound
			// 
			this.comboBoxChooseSound.FormattingEnabled = true;
			this.comboBoxChooseSound.Location = new System.Drawing.Point(16, 13);
			this.comboBoxChooseSound.Name = "comboBoxChooseSound";
			this.comboBoxChooseSound.Size = new System.Drawing.Size(394, 21);
			this.comboBoxChooseSound.TabIndex = 0;
			this.comboBoxChooseSound.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseSound_SelectedIndexChanged);
			// 
			// btnPlayStop
			// 
			this.btnPlayStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPlayStop.Location = new System.Drawing.Point(16, 53);
			this.btnPlayStop.Name = "btnPlayStop";
			this.btnPlayStop.Size = new System.Drawing.Size(90, 40);
			this.btnPlayStop.TabIndex = 1;
			this.btnPlayStop.Text = "Play";
			this.btnPlayStop.UseVisualStyleBackColor = true;
			this.btnPlayStop.Click += new System.EventHandler(this.btnPlayStop_Click);
			// 
			// btnChooseSoundOK
			// 
			this.btnChooseSoundOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnChooseSoundOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnChooseSoundOK.Location = new System.Drawing.Point(224, 63);
			this.btnChooseSoundOK.Name = "btnChooseSoundOK";
			this.btnChooseSoundOK.Size = new System.Drawing.Size(90, 30);
			this.btnChooseSoundOK.TabIndex = 2;
			this.btnChooseSoundOK.Text = "OK";
			this.btnChooseSoundOK.UseVisualStyleBackColor = true;
			this.btnChooseSoundOK.Click += new System.EventHandler(this.btnChooseSoundOK_Click);
			// 
			// btnChooseSoundCancel
			// 
			this.btnChooseSoundCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnChooseSoundCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnChooseSoundCancel.Location = new System.Drawing.Point(320, 63);
			this.btnChooseSoundCancel.Name = "btnChooseSoundCancel";
			this.btnChooseSoundCancel.Size = new System.Drawing.Size(90, 30);
			this.btnChooseSoundCancel.TabIndex = 3;
			this.btnChooseSoundCancel.Text = "Cancel";
			this.btnChooseSoundCancel.UseVisualStyleBackColor = true;
			// 
			// ChooseSound
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 104);
			this.Controls.Add(this.btnChooseSoundCancel);
			this.Controls.Add(this.btnChooseSoundOK);
			this.Controls.Add(this.btnPlayStop);
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
		private System.Windows.Forms.Button btnPlayStop;
		private System.Windows.Forms.Button btnChooseSoundOK;
		private System.Windows.Forms.Button btnChooseSoundCancel;
	}
}