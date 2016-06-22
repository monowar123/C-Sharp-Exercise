using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        HScrollBar hScroller = new HScrollBar();
        VScrollBar vScroller = new VScrollBar();
        int xp;
        int yp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            hScroller.Height = 20;
            hScroller.Width = 300;
            pictureBox1.Controls.Add(hScroller);
            hScroller.Dock = DockStyle.Bottom;
            hScroller.Minimum = 0;
            hScroller.Maximum = 100;
            hScroller.Value = 0;
            hScroller.Scroll += new ScrollEventHandler(HandleScroll);

            vScroller.Height = 300;
            vScroller.Width = 20;
            pictureBox1.Controls.Add(vScroller);
            vScroller.Dock = DockStyle.Right;
            vScroller.Minimum = 0;
            hScroller.Maximum = pictureBox1.Image.Height;
            vScroller.Value = 0;
            vScroller.Scroll += new ScrollEventHandler(HandleScroll);
        }      

        private void HandleScroll(Object sender, ScrollEventArgs e)
        {
            //Create a graphics object and draw a portion of the image in the PictureBox.
            Graphics g = pictureBox1.CreateGraphics();

            int xWidth = pictureBox1.Width;
            int yHeight = pictureBox1.Height;

            
            
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                xp = e.NewValue;
                
                yp = vScroller.Value;
                //MessageBox.Show("xp=" + xp.ToString());
            }
            else //e.ScrollOrientation == ScrollOrientation.VerticalScroll
            {
                yp = e.NewValue;                
                xp = hScroller.Value;
                //MessageBox.Show("yp=" + yp.ToString());
            }

            g.DrawImage(pictureBox1.Image,
              new Rectangle(0, 0, xWidth, yHeight),  //where to draw the image
              new Rectangle(xp, yp, xWidth, yHeight),  //the portion of the image to draw
              GraphicsUnit.Pixel);
           
            pictureBox1.Update();
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Program Files\Google\Google Talk\googletalk.exe");
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
            button1.Text = "monowar.mbstu@gmail.com";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "The cursor is leaved";
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();

            int xWidth = pictureBox1.Width;
            int yHeight = pictureBox1.Height;



            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                yp = e.NewValue;                
            }           
            
            g.DrawImage(pictureBox1.Image,
              new Rectangle(0, 0, xWidth, yHeight),  //where to draw the image
              new Rectangle(xp, yp, xWidth, yHeight),  //the portion of the image to draw
              GraphicsUnit.Pixel);

            pictureBox1.Update();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.gmail.com");
        }

    }
}
