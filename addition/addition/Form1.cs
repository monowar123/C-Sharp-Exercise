using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace addition
{
    public partial class Form1 : Form
    {
        double a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int temp = 1;
            if (temp == 1)
            {
                try
                {
                    a = Convert.ToDouble(input1.Text);
                    b = Convert.ToDouble(input2.Text);
                    temp = 1;
                }
                catch
                {
                    output.Text = "Invalid Input";
                    temp = 0;
                }
            }
            if (temp == 1)
            {
                if (operation.SelectedItem.ToString() == " None")
                {
                    output.Text = "No item is selected";
                }
                else if (operation.SelectedItem.ToString() == "Addition")
                {
                    output.Text = Convert.ToString(a + b);
                }
                else if (operation.SelectedItem.ToString() == "Subtraction")
                {
                    output.Text = Convert.ToString(a - b);
                }
                else if (operation.SelectedItem.ToString() == "Multiplication")
                {
                    output.Text = Convert.ToString(a * b);
                }
                else if (operation.SelectedItem.ToString() == "Divition")
                {
                    output.Text = Convert.ToString(a / b);
                }
            }
        }
    }
}
