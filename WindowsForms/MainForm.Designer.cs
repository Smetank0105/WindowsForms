
namespace WindowsForms
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelCurrentTime = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.labelCurrentDate = new System.Windows.Forms.Label();
			this.labelCurrentDay = new System.Windows.Forms.Label();
			this.checkBoxDate = new System.Windows.Forms.CheckBox();
			this.checkBoxDay = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// labelCurrentTime
			// 
			this.labelCurrentTime.AutoSize = true;
			this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCurrentTime.Location = new System.Drawing.Point(13, 13);
			this.labelCurrentTime.Name = "labelCurrentTime";
			this.labelCurrentTime.Size = new System.Drawing.Size(252, 51);
			this.labelCurrentTime.TabIndex = 0;
			this.labelCurrentTime.Text = "currentTime";
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// labelCurrentDate
			// 
			this.labelCurrentDate.AutoSize = true;
			this.labelCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCurrentDate.Location = new System.Drawing.Point(13, 64);
			this.labelCurrentDate.Name = "labelCurrentDate";
			this.labelCurrentDate.Size = new System.Drawing.Size(247, 51);
			this.labelCurrentDate.TabIndex = 1;
			this.labelCurrentDate.Text = "currentDate";
			// 
			// labelCurrentDay
			// 
			this.labelCurrentDay.AutoSize = true;
			this.labelCurrentDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCurrentDay.Location = new System.Drawing.Point(13, 115);
			this.labelCurrentDay.Name = "labelCurrentDay";
			this.labelCurrentDay.Size = new System.Drawing.Size(233, 51);
			this.labelCurrentDay.TabIndex = 2;
			this.labelCurrentDay.Text = "currentDay";
			// 
			// checkBoxDate
			// 
			this.checkBoxDate.AutoSize = true;
			this.checkBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxDate.Location = new System.Drawing.Point(341, 13);
			this.checkBoxDate.Name = "checkBoxDate";
			this.checkBoxDate.Size = new System.Drawing.Size(99, 20);
			this.checkBoxDate.TabIndex = 3;
			this.checkBoxDate.Text = "show Date";
			this.checkBoxDate.UseVisualStyleBackColor = true;
			// 
			// checkBoxDay
			// 
			this.checkBoxDay.AutoSize = true;
			this.checkBoxDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxDay.Location = new System.Drawing.Point(341, 39);
			this.checkBoxDay.Name = "checkBoxDay";
			this.checkBoxDay.Size = new System.Drawing.Size(94, 20);
			this.checkBoxDay.TabIndex = 4;
			this.checkBoxDay.Text = "show Day";
			this.checkBoxDay.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.checkBoxDay);
			this.Controls.Add(this.checkBoxDate);
			this.Controls.Add(this.labelCurrentDay);
			this.Controls.Add(this.labelCurrentDate);
			this.Controls.Add(this.labelCurrentTime);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Clock";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCurrentTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label labelCurrentDate;
		private System.Windows.Forms.Label labelCurrentDay;
		private System.Windows.Forms.CheckBox checkBoxDate;
		private System.Windows.Forms.CheckBox checkBoxDay;
	}
}

