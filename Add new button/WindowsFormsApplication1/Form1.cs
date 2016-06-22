using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Clicked!";
            //button1.Text = "clicked";

            Button newButton = new Button();
            Controls.Add(newButton);
            newButton.Text = "New Button!";         
            newButton.Click += new EventHandler(newButton_Click);
            //Controls.Add(newButton);
         
            //Button mybutton = new Button();
            //Controls.Add(mybutton);
            //mybutton.Text = "monowar";

            
        }
        private void newButton_Click(object sender, System.EventArgs e)
        {
            ((Button)sender).Text = "Clicked!!";
            this.Text = "new button clicked";
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Monowar";
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            label1.Text = "Anindya";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Anindya";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("hello");
        }        

    }
}
