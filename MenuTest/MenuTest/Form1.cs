using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Use the Format menu to change\nthe appearance of this text.";
            blackToolStripMenuItem.Checked = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an example\nof using menus.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearColor()
        {
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
        }

        private void ClearFont()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            courierNewToolStripMenuItem.Checked = false;
            comicSanMSToolStripMenuItem.Checked = false;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            timesNewRomanToolStripMenuItem.Checked = true;
            label1.Font = new Font("Times New Roman", 14, label1.Font.Style);
        }

        private void courierNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            courierNewToolStripMenuItem.Checked = true;
            label1.Font = new Font("Courier", 14, label1.Font.Style);
        }

        private void comicSanMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            comicSanMSToolStripMenuItem.Checked = true;
            label1.Font = new Font("Comic Sans MS", 14, label1.Font.Style);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Italic);
        }

    }
}
