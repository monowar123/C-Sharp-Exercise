using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            DateTime dd = dateTimePicker1.Value;
            if (dd.DayOfWeek == DayOfWeek.Friday ||
                dd.DayOfWeek == DayOfWeek.Saturday ||
                dd.DayOfWeek == DayOfWeek.Sunday)
            {
                textBox1.Text = dd.AddDays(3).ToLongDateString();
                textBox1.BackColor = Color.Red;
            }
            else
            {
                textBox1.Text = dd.AddDays(2).ToLongDateString();
                textBox1.BackColor = Color.Purple;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(1);
        }
     
    }
}
