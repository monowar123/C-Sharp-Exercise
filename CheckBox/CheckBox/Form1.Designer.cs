namespace CheckBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.Bold_CheckBox = new System.Windows.Forms.CheckBox();
            this.Italic_CheckBox = new System.Windows.Forms.CheckBox();
            this.Strikeout_CheckBox = new System.Windows.Forms.CheckBox();
            this.Underline_CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Watch the font style change";
            // 
            // Bold_CheckBox
            // 
            this.Bold_CheckBox.AutoSize = true;
            this.Bold_CheckBox.Location = new System.Drawing.Point(39, 119);
            this.Bold_CheckBox.Name = "Bold_CheckBox";
            this.Bold_CheckBox.Size = new System.Drawing.Size(47, 17);
            this.Bold_CheckBox.TabIndex = 1;
            this.Bold_CheckBox.Text = "Bold";
            this.Bold_CheckBox.UseVisualStyleBackColor = true;
            this.Bold_CheckBox.CheckedChanged += new System.EventHandler(this.Bold_CheckBox_CheckedChanged);
            // 
            // Italic_CheckBox
            // 
            this.Italic_CheckBox.AutoSize = true;
            this.Italic_CheckBox.Location = new System.Drawing.Point(156, 119);
            this.Italic_CheckBox.Name = "Italic_CheckBox";
            this.Italic_CheckBox.Size = new System.Drawing.Size(48, 17);
            this.Italic_CheckBox.TabIndex = 2;
            this.Italic_CheckBox.Text = "Italic";
            this.Italic_CheckBox.UseVisualStyleBackColor = true;
            this.Italic_CheckBox.CheckedChanged += new System.EventHandler(this.Italic_CheckBox_CheckedChanged);
            // 
            // Strikeout_CheckBox
            // 
            this.Strikeout_CheckBox.AutoSize = true;
            this.Strikeout_CheckBox.Location = new System.Drawing.Point(39, 158);
            this.Strikeout_CheckBox.Name = "Strikeout_CheckBox";
            this.Strikeout_CheckBox.Size = new System.Drawing.Size(68, 17);
            this.Strikeout_CheckBox.TabIndex = 3;
            this.Strikeout_CheckBox.Text = "Strikeout";
            this.Strikeout_CheckBox.UseVisualStyleBackColor = true;
            this.Strikeout_CheckBox.CheckedChanged += new System.EventHandler(this.Strikeout_CheckBox_CheckedChanged);
            // 
            // Underline_CheckBox
            // 
            this.Underline_CheckBox.AutoSize = true;
            this.Underline_CheckBox.Location = new System.Drawing.Point(156, 158);
            this.Underline_CheckBox.Name = "Underline_CheckBox";
            this.Underline_CheckBox.Size = new System.Drawing.Size(71, 17);
            this.Underline_CheckBox.TabIndex = 4;
            this.Underline_CheckBox.Text = "Underline";
            this.Underline_CheckBox.UseVisualStyleBackColor = true;
            this.Underline_CheckBox.CheckedChanged += new System.EventHandler(this.Underline_CheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.Underline_CheckBox);
            this.Controls.Add(this.Strikeout_CheckBox);
            this.Controls.Add(this.Italic_CheckBox);
            this.Controls.Add(this.Bold_CheckBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Check Box Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Bold_CheckBox;
        private System.Windows.Forms.CheckBox Italic_CheckBox;
        private System.Windows.Forms.CheckBox Strikeout_CheckBox;
        private System.Windows.Forms.CheckBox Underline_CheckBox;
    }
}

