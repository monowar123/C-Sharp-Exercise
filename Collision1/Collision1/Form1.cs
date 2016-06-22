using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Collision1
{
    public partial class Form1 : Form
    {
        static int xGreen;
        static int xBrown;
        static int yGreen;
        static int yBrown;

        static bool isMovingDownGreen;
        static bool isMovingDownBrown;
        static bool isMovingRightGreen;
        static bool isMovingRightBrown;

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(900, 600);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xGreen=10;
            yGreen=10;

            xBrown = 500;
            yBrown=500;

            isMovingDownGreen = false;
            isMovingDownBrown = false;
            isMovingRightGreen = false;
            isMovingRightBrown = false;

            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void tmrMover_Tick(object sender, EventArgs e)
        {
            if (isMovingRightGreen == true)
                xGreen++;
            else
                xGreen--;
            if (isMovingDownGreen == true)
                yGreen++;
            else
                yGreen--;

            if ((xGreen + pbxGreen.Width) >= ClientSize.Width)
                isMovingRightGreen = false;
            if ((xGreen + pbxGreen.Width) <= 100)
                isMovingRightGreen = true;

            if ((yGreen + pbxGreen.Height) >= ClientSize.Height)
                isMovingDownGreen = false;
            if ((yGreen + pbxGreen.Height) <= 50)
                isMovingDownGreen = true;

            BackColor = Color.Black;

            pbxGreen.Location = new Point(xGreen, yGreen);

            //////////////////////////////////////////////////
            if (isMovingRightBrown == true)
                xBrown += 2;
            else
                xBrown--;
            if (isMovingDownBrown == true)
                yBrown += 2;
            else 
                yBrown--;

            if ((xBrown + pbxBrown.Width) >= ClientSize.Width)
                isMovingRightBrown = false;
            if ((xBrown + pbxBrown.Width) <= 100)
                isMovingRightBrown = true; ;

            if ((yBrown + pbxBrown.Height) >= ClientSize.Height)
                isMovingDownBrown = false;
            if ((yBrown + pbxBrown.Height) <= 50)
                isMovingDownBrown = true;

            pbxBrown.Location = new Point(xBrown, yBrown);

            if (pbxBrown.Bounds.IntersectsWith(pbxGreen.Bounds))
            {
                tmrMover.Enabled = false;

                Random rndNumber = new Random();

                xGreen = rndNumber.Next(Width);
                xBrown = rndNumber.Next(Width);

                yGreen = rndNumber.Next(Height);
                yBrown = rndNumber.Next(Height);

                tmrMover.Enabled = true;
            }
        }
    }
}