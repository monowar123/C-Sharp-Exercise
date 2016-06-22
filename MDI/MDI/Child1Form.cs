using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI
{
    public partial class Child1Form : Form
    {
        public Child1Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Child2Form objchild2 = new Child2Form();
            objchild2.MdiParent = this.MdiParent;
            objchild2.Show();
        }
    }
}
