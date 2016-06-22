using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckedLIstBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = checkedListBox1.SelectedItem.ToString();
            if (e.NewValue == CheckState.Checked)
                listBox1.Items.Add(item);
            else
                listBox1.Items.Remove(item);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
