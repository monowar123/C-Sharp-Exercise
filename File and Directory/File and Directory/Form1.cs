using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace File_and_Directory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string fileName = textBox1.Text;
                if (File.Exists(fileName))
                {
                    GetInformation(fileName);
                    StreamReader stream = null;
                    try
                    {
                        stream = new StreamReader(fileName);
                        textBox2.AppendText("\n\nContents of the file: \n\n");
                        textBox2.AppendText(stream.ReadToEnd());
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error reading from file.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Directory.Exists(fileName))
                {
                    GetInformation(fileName);
                    string[] directoryList = Directory.GetDirectories(fileName);
                    textBox2.AppendText("Directory contents:\n");
                    foreach (var directory in directoryList)
                        textBox2.AppendText(directory + "\n");
                }
                else
                {
                    MessageBox.Show(textBox1.Text + " does not exit.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetInformation(string fileName)
        {           
            textBox2.Clear();
            textBox2.AppendText(fileName + " exists.\n");
            textBox2.AppendText("Created: " + File.GetCreationTime(fileName) + "\n");
            textBox2.AppendText("Last Modified: " + File.GetLastWriteTime(fileName) + "\n");
            textBox2.AppendText("Last Accessed: " + File.GetLastAccessTime(fileName) + "\n");
        }
    }
}
