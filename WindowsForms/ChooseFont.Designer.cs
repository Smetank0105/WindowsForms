
namespace WindowsForms
{
	partial class ChooseFont
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFont));
			this.lblChooseFont = new System.Windows.Forms.Label();
			this.comboBoxChooseFont = new System.Windows.Forms.ComboBox();
			this.lblExample = new System.Windows.Forms.Label();
			this.lblFilename = new System.Windows.Forms.Label();
			this.nudFontSize = new System.Windows.Forms.NumericUpDown();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
			this.SuspendLayout();
			// 
			// lblChooseFont
			// 
			this.lblChooseFont.AutoSize = true;
			this.lblChooseFont.Location = new System.Drawing.Point(12, 9);
			this.lblChooseFont.Name = "lblChooseFont";
			this.lblChooseFont.Size = new System.Drawing.Size(93, 13);
			this.lblChooseFont.TabIndex = 0;
			this.lblChooseFont.Text = "Выберите шрифт";
			// 
			// comboBoxChooseFont
			// 
			this.comboBoxChooseFont.FormattingEnabled = true;
			this.comboBoxChooseFont.Location = new System.Drawing.Point(13, 26);
			this.comboBoxChooseFont.Name = "comboBoxChooseFont";
			this.comboBoxChooseFont.Size = new System.Drawing.Size(407, 21);
			this.comboBoxChooseFont.Sorted = true;
			this.comboBoxChooseFont.TabIndex = 1;
			this.comboBoxChooseFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseFont_SelectedIndexChanged);
			// 
			// lblExample
			// 
			this.lblExample.AutoSize = true;
			this.lblExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblExample.Location = new System.Drawing.Point(12, 82);
			this.lblExample.Name = "lblExample";
			this.lblExample.Size = new System.Drawing.Size(282, 73);
			this.lblExample.TabIndex = 2;
			this.lblExample.Text = "Example";
			// 
			// lblFilename
			// 
			this.lblFilename.AutoSize = true;
			this.lblFilename.Location = new System.Drawing.Point(13, 54);
			this.lblFilename.Name = "lblFilename";
			this.lblFilename.Size = new System.Drawing.Size(52, 13);
			this.lblFilename.TabIndex = 3;
			this.lblFilename.Text = "Filename:";
			// 
			// nudFontSize
			// 
			this.nudFontSize.Location = new System.Drawing.Point(426, 27);
			this.nudFontSize.Name = "nudFontSize";
			this.nudFontSize.Size = new System.Drawing.Size(120, 20);
			this.nudFontSize.TabIndex = 4;
			this.nudFontSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.nudFontSize.ValueChanged += new System.EventHandler(this.nudFontSize_ValueChanged);
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(384, 235);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 5;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(465, 235);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// ChooseFont
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 270);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.nudFontSize);
			this.Controls.Add(this.lblFilename);
			this.Controls.Add(this.lblExample);
			this.Controls.Add(this.comboBoxChooseFont);
			this.Controls.Add(this.lblChooseFont);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ChooseFont";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ChooseFont";
			((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblChooseFont;
		private System.Windows.Forms.ComboBox comboBoxChooseFont;
		private System.Windows.Forms.Label lblExample;
		private System.Windows.Forms.Label lblFilename;
		private System.Windows.Forms.NumericUpDown nudFontSize;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
	}
}