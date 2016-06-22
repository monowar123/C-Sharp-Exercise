using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Collection_exersize
{
    public partial class Form1 : Form
    {
        private ListBox lbxNumbers;

        public Form1()
        {
            InitializeComponent();

            lbxNumbers = new ListBox();
            lbxNumbers.Width = 100;
            lbxNumbers.Location = new System.Drawing.Point(12, 12);

            Text = "Numbers";
            MinimizeBox = false;
            MaximizeBox = false;
            Controls.Add(this.lbxNumbers);        
            Size = new System.Drawing.Size(130, 145);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Collection<double> coll = new Collection<double>();

            coll.Add(1244.1250);
            coll.Add(224.52);
            coll.Add(64525.38);
            coll.Add(1005.36);
            coll.Add(86.828);
            coll.Add(2448.362);
            coll.Add(632.04);
            coll.Add(86.828);
            coll.Add(2448.362);
            coll.Add(632.04);

            //for (int n = 0; n < coll.Count; n++)
            //    lbxNumbers.Items.Add(coll[n]);  //this is called by indexer
            // or
            foreach (var n in coll)
                lbxNumbers.Items.Add(n.ToString());
        }
    }
}
