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
    public partial class Form2 : Form
    {
        int a = 0;
        //Class1 obj2 = new Class1();
        public Form2(Class1 obj)
        {
            InitializeComponent();
            label1.Text = obj.name; 
            //obj2 = obj;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                this.Text = "Monowarul";
                label1.Text = "Monowarul";
                a = 1;
            }
            else if (a == 1)
            {
                this.Text = "Islam";
                label1.Text = "Islam";
                a = 0;
            }
            //label1.Text = obj2.name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
