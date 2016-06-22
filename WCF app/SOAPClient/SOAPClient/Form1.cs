using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOAPClient
{
    public partial class Form1 : Form
    {
        private WelcomeService.WelcomeSOAPServiceClient client;
        
        public Form1()
        {
            InitializeComponent();
            client = new WelcomeService.WelcomeSOAPServiceClient();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                MessageBox.Show(client.Welcome(txtName.Text), "Welcome");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }
    }
}
