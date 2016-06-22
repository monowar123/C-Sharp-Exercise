using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Article_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

 


        public void PrintColorComponents(int x,int y)
        {
           Bitmap image = new Bitmap(pictureBox1.Image);
           lbCoordinates.Text = x.ToString() + "," + y.ToString();
           Color color = image.GetPixel(x, y);
           lbRed.Text = color.R.ToString();
           lbGreen.Text = color.G.ToString();
           lbBlue.Text = color.B.ToString();
            
        }

       

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            PrintColorComponents(e.X,e.Y);
        }
    }
}
