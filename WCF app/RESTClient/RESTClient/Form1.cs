using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;

namespace RESTClient
{
    public partial class Form1 : Form
    {
        private WebClient client = new WebClient();
        private XNamespace xmlNamespace = XNamespace.Get("http://schemas.microsoft.com/2003/10/Serialization/");

        public Form1()
        {
            InitializeComponent();
            client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                client.DownloadStringAsync(new Uri("http://localhost:1391/WelcomeRESTService.svc?wsdl/welcome/" + txtName.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                if (e.Error == null)
                {
                    XDocument xmlResponse = XDocument.Parse(e.Result);

                    MessageBox.Show(xmlResponse.Element(xmlNamespace + "string").Value, "Welcome");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
