namespace countstring
{
    partial class gggg
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vowel = new System.Windows.Forms.Label();
            this.consonant = new System.Windows.Forms.Label();
            this.disit = new System.Windows.Forms.Label();
            this.spchar = new System.Windows.Forms.Label();
            this.vshow = new System.Windows.Forms.Label();
            this.cshow = new System.Windows.Forms.Label();
            this.dshow = new System.Windows.Forms.Label();
            this.spshow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputtext
            // 
            this.inputtext.Location = new System.Drawing.Point(39, 13);
            this.inputtext.Multiline = true;
            this.inputtext.Name = "inputtext";
            this.inputtext.Size = new System.Drawing.Size(241, 20);
            this.inputtext.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input";
            // 
            // vowel
            // 
            this.vowel.AutoSize = true;
            this.vowel.Location = new System.Drawing.Point(2, 102);
            this.vowel.Name = "vowel";
            this.vowel.Size = new System.Drawing.Size(36, 13);
            this.vowel.TabIndex = 3;
            this.vowel.Text = "Vowel";
            this.vowel.Click += new System.EventHandler(this.vowel_Click);
            // 
            // consonant
            // 
            this.consonant.AutoSize = true;
            this.consonant.Location = new System.Drawing.Point(2, 138);
            this.consonant.Name = "consonant";
            this.consonant.Size = new System.Drawing.Size(58, 13);
            this.consonant.TabIndex = 4;
            this.consonant.Text = "Consonant";
            // 
            // disit
            // 
            this.disit.AutoSize = true;
            this.disit.Location = new System.Drawing.Point(2, 171);
            this.disit.Name = "disit";
            this.disit.Size = new System.Drawing.Size(27, 13);
            this.disit.TabIndex = 5;
            this.disit.Text = "Disit";
            // 
            // spchar
            // 
            this.spchar.AutoSize = true;
            this.spchar.Location = new System.Drawing.Point(2, 208);
            this.spchar.Name = "spchar";
            this.spchar.Size = new System.Drawing.Size(47, 13);
            this.spchar.TabIndex = 6;
            this.spchar.Text = "Sp_char";
            // 
            // vshow
            // 
            this.vshow.AutoSize = true;
            this.vshow.Location = new System.Drawing.Point(105, 102);
            this.vshow.Name = "vshow";
            this.vshow.Size = new System.Drawing.Size(0, 13);
            this.vshow.TabIndex = 7;
            // 
            // cshow
            // 
            this.cshow.AutoSize = true;
            this.cshow.Location = new System.Drawing.Point(105, 138);
            this.cshow.Name = "cshow";
            this.cshow.Size = new System.Drawing.Size(0, 13);
            this.cshow.TabIndex = 8;
            // 
            // dshow
            // 
            this.dshow.AutoSize = true;
            this.dshow.Location = new System.Drawing.Point(105, 171);
            this.dshow.Name = "dshow";
            this.dshow.Size = new System.Drawing.Size(0, 13);
            this.dshow.TabIndex = 9;
            // 
            // spshow
            // 
            this.spshow.AutoSize = true;
            this.spshow.Location = new System.Drawing.Point(105, 208);
            this.spshow.Name = "spshow";
            this.spshow.Size = new System.Drawing.Size(0, 13);
            this.spshow.TabIndex = 10;
            // 
            // gggg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.spshow);
            this.Controls.Add(this.dshow);
            this.Controls.Add(this.cshow);
            this.Controls.Add(this.vshow);
            this.Controls.Add(this.spchar);
            this.Controls.Add(this.disit);
            this.Controls.Add(this.consonant);
            this.Controls.Add(this.vowel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputtext);
            this.Controls.Add(this.button1);
            this.Name = "gggg";
            this.Text = "1234";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vowel;
        private System.Windows.Forms.Label consonant;
        private System.Windows.Forms.Label disit;
        private System.Windows.Forms.Label spchar;
        private System.Windows.Forms.Label vshow;
        private System.Windows.Forms.Label cshow;
        private System.Windows.Forms.Label dshow;
        private System.Windows.Forms.Label spshow;
    }
}

