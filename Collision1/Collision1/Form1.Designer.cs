namespace Collision1
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
            this.pbxGreen = new System.Windows.Forms.PictureBox();
            this.pbxBrown = new System.Windows.Forms.PictureBox();
            this.tmrMover = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBrown)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxGreen
            // 
            this.pbxGreen.BackColor = System.Drawing.Color.Green;
            this.pbxGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxGreen.Location = new System.Drawing.Point(40, 49);
            this.pbxGreen.Name = "pbxGreen";
            this.pbxGreen.Size = new System.Drawing.Size(100, 50);
            this.pbxGreen.TabIndex = 0;
            this.pbxGreen.TabStop = false;
            // 
            // pbxBrown
            // 
            this.pbxBrown.BackColor = System.Drawing.Color.Violet;
            this.pbxBrown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxBrown.Location = new System.Drawing.Point(165, 49);
            this.pbxBrown.Name = "pbxBrown";
            this.pbxBrown.Size = new System.Drawing.Size(100, 50);
            this.pbxBrown.TabIndex = 1;
            this.pbxBrown.TabStop = false;
            // 
            // tmrMover
            // 
            this.tmrMover.Enabled = true;
            this.tmrMover.Interval = 2;
            this.tmrMover.Tick += new System.EventHandler(this.tmrMover_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.pbxBrown);
            this.Controls.Add(this.pbxGreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBrown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxGreen;
        private System.Windows.Forms.PictureBox pbxBrown;
        private System.Windows.Forms.Timer tmrMover;
    }
}

