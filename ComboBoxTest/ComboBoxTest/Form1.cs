using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics myGraphics = base.CreateGraphics();

            Pen myPen = new Pen(Color.DarkRed);

            SolidBrush mySolidBrush = new SolidBrush(Color.DarkRed);

            myGraphics.Clear(Color.White);

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    myGraphics.DrawEllipse(myPen, 50, 50, 150, 150);
                    break;
                case 1:
                    myGraphics.DrawRectangle(myPen, 50, 50, 150, 150);
                    break;
                case 2:
                    myGraphics.DrawEllipse(myPen, 50, 85, 150, 115);
                    break;
                case 3:
                    myGraphics.DrawPie(myPen, 50, 50, 150, 150, 0, 45);
                    break;
                case 4:
                    myGraphics.FillEllipse(mySolidBrush, 50, 50, 150, 150);
                    break;
                case 5:
                    myGraphics.FillRectangle(mySolidBrush, 50, 50, 150, 150);
                    break;
                case 6:
                    myGraphics.FillEllipse(mySolidBrush, 50, 85, 150, 115);
                    break;
                case 7:
                    myGraphics.FillPie(mySolidBrush, 50, 50, 150, 150, 0, 45);
                    break;
                default:
                    break;
            }
        }
    }
}
