using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            string output;
            output = "Name: " + this.textBox_name.Text + "\r\n";
            output += "Address: " + this.textBox_address.Text + "\r\n";
            output += "Occupation: " + this.textBox_occupation.Text + "\r\n";
            output += "Age: " + this.textBox_age.Text;

            this.textBox_output.Text = output;
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            string output;
            output = "Name=Your name\r\n";
            output += "Address=Your address\r\n";
            output += "Occupation=Only allowed value is 'Programmer'\r\n";
            output += "Age=Your age\r\n";

            this.textBox_output.Text = output;
        }
    }
}
