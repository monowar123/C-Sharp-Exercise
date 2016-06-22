using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Painter
{
    public partial class Form1 : Form
    {
       private bool paint = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Graphics gl = panel1.CreateGraphics();
            gl.Clear(panel1.BackColor);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint && (e.Button == MouseButtons.Left))
            {
                //color = new SolidBrush(Color.Black);
                Brush color=new SolidBrush(Color.Black);
                Graphics gg = panel1.CreateGraphics();
                gg.FillEllipse(color, e.X, e.Y, 4, 4);
                gg.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
