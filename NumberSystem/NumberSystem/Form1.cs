using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumberSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var value = Convert.ToDouble(textBox1.Text);
            //var rusult=Convert.ToInt64()
            int bb=Convert.ToInt32(textBox3.Text);
            label3.Text = Convert.ToString(value,2).ToUpper();
        }
    }
}
