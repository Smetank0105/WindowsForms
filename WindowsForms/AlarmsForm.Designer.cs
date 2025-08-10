
namespace WindowsForms
{
	partial class AlarmsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmsForm));
			this.dtpAlarmsForm = new System.Windows.Forms.DateTimePicker();
			this.btnAlarmsFormAdd = new System.Windows.Forms.Button();
			this.lbAlarmsForm = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// dtpAlarmsForm
			// 
			this.dtpAlarmsForm.CustomFormat = "ddMMMMyyyy  HH:mm:ss";
			this.dtpAlarmsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpAlarmsForm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpAlarmsForm.Location = new System.Drawing.Point(12, 12);
			this.dtpAlarmsForm.Name = "dtpAlarmsForm";
			this.dtpAlarmsForm.ShowUpDown = true;
			this.dtpAlarmsForm.Size = new System.Drawing.Size(259, 29);
			this.dtpAlarmsForm.TabIndex = 0;
			// 
			// btnAlarmsFormAdd
			// 
			this.btnAlarmsFormAdd.Location = new System.Drawing.Point(277, 11);
			this.btnAlarmsFormAdd.Name = "btnAlarmsFormAdd";
			this.btnAlarmsFormAdd.Size = new System.Drawing.Size(94, 30);
			this.btnAlarmsFormAdd.TabIndex = 1;
			this.btnAlarmsFormAdd.Text = "Add";
			this.btnAlarmsFormAdd.UseVisualStyleBackColor = true;
			this.btnAlarmsFormAdd.Click += new System.EventHandler(this.btnAlarmsFormAdd_Click);
			// 
			// lbAlarmsForm
			// 
			this.lbAlarmsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbAlarmsForm.FormatString = "F";
			this.lbAlarmsForm.FormattingEnabled = true;
			this.lbAlarmsForm.ItemHeight = 24;
			this.lbAlarmsForm.Location = new System.Drawing.Point(12, 47);
			this.lbAlarmsForm.Name = "lbAlarmsForm";
			this.lbAlarmsForm.Size = new System.Drawing.Size(259, 340);
			this.lbAlarmsForm.TabIndex = 3;
			this.lbAlarmsForm.DoubleClick += new System.EventHandler(this.lbAlarmsForm_DoubleClick);
			// 
			// AlarmsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 398);
			this.Controls.Add(this.lbAlarmsForm);
			this.Controls.Add(this.btnAlarmsFormAdd);
			this.Controls.Add(this.dtpAlarmsForm);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AlarmsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Alarms";
			this.TopMost = true;
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpAlarmsForm;
		private System.Windows.Forms.Button btnAlarmsFormAdd;
		private System.Windows.Forms.ListBox lbAlarmsForm;
	}
}