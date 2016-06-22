using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Progress_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            int H = currentTime.Hour;
            int M = currentTime.Minute;
            int S = currentTime.Second;

            pgrHours.Value = H;
            pgrMinutes.Value = M;
            pgrSeconds.Value = S;

            labelHours.Text = H.ToString();
            labelMinutes.Text = M.ToString();
            labelSeconds.Text = S.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            //MessageBox.Show("Hello");
        }
    }
}
