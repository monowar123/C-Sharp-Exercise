namespace Progress_Clock
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
            this.pgrHours = new System.Windows.Forms.ProgressBar();
            this.pgrMinutes = new System.Windows.Forms.ProgressBar();
            this.pgrSeconds = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pgrHours
            // 
            this.pgrHours.Location = new System.Drawing.Point(72, 33);
            this.pgrHours.Maximum = 23;
            this.pgrHours.Name = "pgrHours";
            this.pgrHours.Size = new System.Drawing.Size(248, 23);
            this.pgrHours.Step = 1;
            this.pgrHours.TabIndex = 0;
            // 
            // pgrMinutes
            // 
            this.pgrMinutes.Location = new System.Drawing.Point(72, 84);
            this.pgrMinutes.Maximum = 59;
            this.pgrMinutes.Name = "pgrMinutes";
            this.pgrMinutes.Size = new System.Drawing.Size(452, 23);
            this.pgrMinutes.Step = 1;
            this.pgrMinutes.TabIndex = 1;
            // 
            // pgrSeconds
            // 
            this.pgrSeconds.Location = new System.Drawing.Point(72, 130);
            this.pgrSeconds.Maximum = 59;
            this.pgrSeconds.Name = "pgrSeconds";
            this.pgrSeconds.Size = new System.Drawing.Size(452, 23);
            this.pgrSeconds.Step = 1;
            this.pgrSeconds.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seconds";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(504, 176);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(544, 39);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(35, 13);
            this.labelHours.TabIndex = 8;
            this.labelHours.Text = "label5";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(544, 90);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(35, 13);
            this.labelMinutes.TabIndex = 9;
            this.labelMinutes.Text = "label6";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(544, 136);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(35, 13);
            this.labelSeconds.TabIndex = 10;
            this.labelSeconds.Text = "label7";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 213);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgrSeconds);
            this.Controls.Add(this.pgrMinutes);
            this.Controls.Add(this.pgrHours);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgrHours;
        private System.Windows.Forms.ProgressBar pgrMinutes;
        private System.Windows.Forms.ProgressBar pgrSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Timer timer1;
    }
}

