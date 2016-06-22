using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MessagePassing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            string ss = textBox1.Text;
            Class1 obj=new Class1();
            obj.name = ss;
            Form2 ff = new Form2(obj);
            ff.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "My new form";
            frm.Show();
            //Application.Exit();
        }
    }
}
