namespace Clock
{
    partial class Form1
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
            this.Clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StartTime = new System.Windows.Forms.Button();
            this.EndTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Location = new System.Drawing.Point(268, 66);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(0, 12);
            this.Clock.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartTime
            // 
            this.StartTime.Location = new System.Drawing.Point(61, 131);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(207, 23);
            this.StartTime.TabIndex = 1;
            this.StartTime.Text = "Start";
            this.StartTime.UseVisualStyleBackColor = true;
            this.StartTime.Click += new System.EventHandler(this.StartTime_Click);
            // 
            // EndTime
            // 
            this.EndTime.Location = new System.Drawing.Point(344, 131);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(197, 23);
            this.EndTime.TabIndex = 2;
            this.EndTime.Text = "End";
            this.EndTime.UseVisualStyleBackColor = true;
            this.EndTime.Click += new System.EventHandler(this.EndTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.Clock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StartTime;
        private System.Windows.Forms.Button EndTime;
    }
}

