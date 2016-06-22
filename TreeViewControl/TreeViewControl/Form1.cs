using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TreeViewControl
{
    public partial class Form1 : Form
    {
        string substringDirectory;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            if (Directory.Exists(textBox1.Text))
            {
                treeView1.Nodes.Add(textBox1.Text);
                PopulateTreeView(textBox1.Text, treeView1.Nodes[0]);
            }
            else
            {
                MessageBox.Show(textBox1.Text + " could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PopulateTreeView(string directoryValue, TreeNode parentNode)
        {
            string[] directoryArray = Directory.GetDirectories(directoryValue);
            //string[] fileNameArray = Directory.GetFiles(directoryValue);
            try
            {
                if (directoryArray.Length != 0)
                {
                    foreach (string directory in directoryArray)
                    {
                        substringDirectory = Path.GetFileNameWithoutExtension(directory);

                        TreeNode myNode = new TreeNode(substringDirectory);
                        parentNode.Nodes.Add(myNode);

                        PopulateTreeView(directory, myNode);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access Denied.");
            }
        }
    }
}
