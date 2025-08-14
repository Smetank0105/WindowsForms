
namespace WindowsForms
{
	partial class TimerForm
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
			this.lblTimer = new System.Windows.Forms.Label();
			this.btnStartStopTimer = new System.Windows.Forms.Button();
			this.mtbTimer = new System.Windows.Forms.MaskedTextBox();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lblTimer
			// 
			this.lblTimer.AutoSize = true;
			this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTimer.Location = new System.Drawing.Point(12, 9);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(284, 73);
			this.lblTimer.TabIndex = 0;
			this.lblTimer.Text = "00:00:00";
			this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnStartStopTimer
			// 
			this.btnStartStopTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStartStopTimer.Location = new System.Drawing.Point(12, 95);
			this.btnStartStopTimer.Name = "btnStartStopTimer";
			this.btnStartStopTimer.Size = new System.Drawing.Size(284, 60);
			this.btnStartStopTimer.TabIndex = 1;
			this.btnStartStopTimer.Text = "Start";
			this.btnStartStopTimer.UseVisualStyleBackColor = true;
			this.btnStartStopTimer.Click += new System.EventHandler(this.btnStartStopTimer_Click);
			// 
			// mtbTimer
			// 
			this.mtbTimer.BeepOnError = true;
			this.mtbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.mtbTimer.Location = new System.Drawing.Point(12, 9);
			this.mtbTimer.Mask = "00:00:00";
			this.mtbTimer.Name = "mtbTimer";
			this.mtbTimer.Size = new System.Drawing.Size(284, 80);
			this.mtbTimer.TabIndex = 2;
			this.mtbTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mtbTimer.ValidatingType = typeof(System.DateTime);
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// TimerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 170);
			this.Controls.Add(this.mtbTimer);
			this.Controls.Add(this.btnStartStopTimer);
			this.Controls.Add(this.lblTimer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "TimerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Timer";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTimer;
		private System.Windows.Forms.Button btnStartStopTimer;
		private System.Windows.Forms.MaskedTextBox mtbTimer;
		private System.Windows.Forms.Timer timer;
	}
}