namespace student
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.deptname = new System.Windows.Forms.ColumnHeader();
            this.sessionname = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputname = new System.Windows.Forms.TextBox();
            this.dept = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputid = new System.Windows.Forms.TextBox();
            this.session = new System.Windows.Forms.ComboBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.id,
            this.deptname,
            this.sessionname});
            this.listView1.Location = new System.Drawing.Point(-2, 265);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(573, 248);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 220;
            // 
            // id
            // 
            this.id.Text = "ID No.";
            this.id.Width = 136;
            // 
            // deptname
            // 
            this.deptname.Text = "Dept.";
            this.deptname.Width = 100;
            // 
            // sessionname
            // 
            this.sessionname.Text = "Session ";
            this.sessionname.Width = 116;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // inputname
            // 
            this.inputname.Location = new System.Drawing.Point(129, 34);
            this.inputname.Name = "inputname";
            this.inputname.Size = new System.Drawing.Size(269, 20);
            this.inputname.TabIndex = 3;
            // 
            // dept
            // 
            this.dept.FormattingEnabled = true;
            this.dept.Items.AddRange(new object[] {
            "CSE",
            "ICT",
            "TE",
            "FTNS",
            "BGE",
            "ESRM",
            "CPS"});
            this.dept.Location = new System.Drawing.Point(129, 139);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(155, 21);
            this.dept.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Session";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dept.";
            // 
            // inputid
            // 
            this.inputid.Location = new System.Drawing.Point(129, 81);
            this.inputid.Name = "inputid";
            this.inputid.Size = new System.Drawing.Size(155, 20);
            this.inputid.TabIndex = 8;
            // 
            // session
            // 
            this.session.FormattingEnabled = true;
            this.session.Items.AddRange(new object[] {
            "2004-2005",
            "2005-2006",
            "2006-2007",
            "2007-2008",
            "2008-2009",
            "2009-2010",
            "2010-2011"});
            this.session.Location = new System.Drawing.Point(129, 196);
            this.session.Name = "session";
            this.session.Size = new System.Drawing.Size(155, 21);
            this.session.TabIndex = 9;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(452, 199);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 10;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(452, 120);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 11;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(452, 159);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 511);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.session);
            this.Controls.Add(this.inputid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.inputname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            //this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader deptname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputname;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputid;
        private System.Windows.Forms.ComboBox session;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.ColumnHeader sessionname;
    }
}

