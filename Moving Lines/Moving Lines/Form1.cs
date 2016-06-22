using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Moving_Lines
{
    public partial class Form1 : Form
    {
        static int x;
        static int y;
        static bool IsMovingDown;
        static bool IsMovingRight;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
            IsMovingDown = false;
            IsMovingRight = false;
            BackColor = Color.Black;
            ClientSize =new Size(745, 532);         
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (IsMovingRight == true)
                x++;
            else
                x--;
            if (IsMovingDown == true)
                y++;
            else
                y--;
            if ((x + 40) > ClientSize.Width)
                IsMovingRight = false;
            if (x < 0)
                IsMovingRight = true;
            if ((y + 40) > ClientSize.Height)
                IsMovingDown = false;
            if (y < 0)
                IsMovingDown = true;
            e.Graphics.DrawLine(Pens.Aqua, x + 20, 0, x + 20, ClientSize.Height);
            e.Graphics.DrawLine(Pens.Aqua, 0, y + 20, ClientSize.Width, y + 20);
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Invalidate();
            Refresh();
            //Update();
        }
    }
}
