namespace addition
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
            this.operation = new System.Windows.Forms.ComboBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input2 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // operation
            // 
            this.operation.FormattingEnabled = true;
            this.operation.Items.AddRange(new object[] {
            " None",
            "Addition",
            "Subtraction",
            "Multiplication",
            "Divition"});
            this.operation.Location = new System.Drawing.Point(108, 119);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(150, 21);
            this.operation.TabIndex = 0;
            this.operation.SelectedIndexChanged += new System.EventHandler(this.operation_SelectedIndexChanged);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(108, 26);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(150, 20);
            this.input1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "output";
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(108, 68);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(150, 20);
            this.input2.TabIndex = 6;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(108, 181);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(150, 20);
            this.output.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.operation);
            this.Name = "Form1";
            this.Text = "Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox operation;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox output;
    }
}

