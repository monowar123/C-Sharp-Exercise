using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Image File(.jpg)|*.jpg|Image File(.jpeg)|*.jpeg|Image File(.png)|*.png|Bitmap File(.bmp)|*.bmp|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                this.Text = string.Concat("picture viewer(" + openFileDialog1.FileName + ")");

            }
            //pictureBox1.Image = Image.FromFile(@"H:\Picture\28.02.2011\005.JPG");
        }
    }
}
