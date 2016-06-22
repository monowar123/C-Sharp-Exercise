using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Searching_Directories
{
    public partial class Form1 : Form
    {
        string currentDirectory;
        Dictionary<string, int> found = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pathTextBox.Text != string.Empty && !Directory.Exists(pathTextBox.Text))
            {
                MessageBox.Show("Invalid Directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pathTextBox.Text == string.Empty)
                    currentDirectory = Directory.GetCurrentDirectory();
                else
                    currentDirectory = pathTextBox.Text;

                directoryTextBox.Clear();
                pathTextBox.Clear();
                resultTextBox.Clear();

                directoryTextBox.Text = currentDirectory;

                found.Clear();
                SearchDirectory(currentDirectory);
                var noOfFiles = 0;
                foreach (var current in found.Keys)
                {
                    resultTextBox.AppendText(string.Format("* Found {0} {1} files.\r\n", found[current], current));
                    noOfFiles += found[current];
                }
                pathTextBox.Text = noOfFiles.ToString() + " file exists.";
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CleanDirectory(currentDirectory);
        }

        private void SearchDirectory(string folder)
        {
            try
            {
                string[] files = Directory.GetFiles(folder);
                string[] directories = Directory.GetDirectories(folder);
                // find all file extensions.........
                var extensions = (from file in files select Path.GetExtension(file)).Distinct();
                // count the number of files using each extension...
                foreach (var extension in extensions)
                {
                    var temp = extension;
                    var extensionCount = (from file in files where Path.GetExtension(file) == temp select file).Count();
                    if (found.ContainsKey(extension))
                        found[extension] += extensionCount;
                    else
                        found.Add(extension, extensionCount);
                }
                // recursive call to search sub directories...
                foreach (var subDirectory in directories)
                    SearchDirectory(subDirectory);
            }
            catch
            {
                MessageBox.Show("Unable to access some subdirectory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CleanDirectory(string folder)   // it will just delete .bak file.
        {
            string[] files = Directory.GetFiles(folder);
            string[] directories = Directory.GetDirectories(folder);

            var backupFiles = from file in files where Path.GetExtension(file) == ".bak" select file;

            if (backupFiles.Count() > 0)
            {
                foreach (var backup in backupFiles)
                {
                    DialogResult result = MessageBox.Show("Found backup file " + Path.GetFileName(backup) + ". \nDelete?", "Delete BackUp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        File.Delete(backup);
                        --found[".bak"];   // decrement count in dictionary.
                        if (found[".bak"] == 0)
                            found.Remove(".bak");
                    }
                }
            }
            else
                MessageBox.Show("There is no backup file", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pathTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            pathTextBox.Clear();
        }
    }
}
