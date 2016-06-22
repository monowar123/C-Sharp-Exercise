using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ListViewControl
{
    public partial class Form1 : Form
    {
        string currentDirectory = Directory.GetCurrentDirectory();

        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)  //if any item selected
            {
                if (listView1.Items[0].Selected)  // if first item selected
                {
                    DirectoryInfo directoryObject = new DirectoryInfo(currentDirectory); // store all information of current directory
                    if (directoryObject.Parent != null)  //if the previous directory is exist
                    {
                        LoadFilesInDirectory(directoryObject.Parent.FullName);
                    }
                }
                else
                {
                    string chosen = listView1.SelectedItems[0].Text; //first index of selected item
                    if (Directory.Exists(Path.Combine(currentDirectory, chosen)))
                    {  // combine the path current and chosen to obtain the next directory
                        LoadFilesInDirectory(Path.Combine(currentDirectory, chosen));
                    }
                }
                label1.Text = currentDirectory;
            }
        }

        public void LoadFilesInDirectory(string currentDirectoryValue)
        {
            try
            {
                listView1.Items.Clear();
                listView1.Items.Add("Go up one level"); // add first item of the list box

                currentDirectory = currentDirectoryValue;  //update currentDirectory

                DirectoryInfo directoryObject = new DirectoryInfo(currentDirectory);
                DirectoryInfo[] directoryArray = directoryObject.GetDirectories();
                FileInfo[] fileArray = directoryObject.GetFiles(); // store file info of dirctoryObject

                foreach (DirectoryInfo dir in directoryArray)
                {
                    ListViewItem newDirectoryItem = listView1.Items.Add(dir.Name);
                    newDirectoryItem.ImageIndex = 0; // set directory or folder image 
                }
                foreach (FileInfo file in fileArray)
                {
                    ListViewItem newFileItem = listView1.Items.Add(file.Name);
                    newFileItem.ImageIndex = 1;     // set file image
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Some fields may not be accessible.", "Attention", 0, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fileFolderImageList.Images.Add(Properties.Resources.Folder); //Folder is the image name
            //fileFolderImageList.Images.Add(Properties.Resources.File);   //File is the image name
            LoadFilesInDirectory(currentDirectory);
            label1.Text = currentDirectory;
        }
    }
}
