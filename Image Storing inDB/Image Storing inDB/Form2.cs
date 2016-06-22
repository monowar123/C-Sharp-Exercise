using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Image_Storing_inDB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                btnSave.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imageData = ReadFile(txtImagePath.Text);

                string conString = @"Data Source=MONOWAR-PC; Initial Catalog=store_image; User ID=sa; Password=cse";
                string sqlString = "insert into [image_table] (image_path, picture) values(@image_path, @picture)";

                SqlConnection conn = new SqlConnection(conString);

                SqlCommand sqlCommandObject = new SqlCommand(sqlString, conn);

                sqlCommandObject.Parameters.Add(new SqlParameter("@image_path", (object)txtImagePath.Text));
                sqlCommandObject.Parameters.Add(new SqlParameter("@picture", (object)imageData));

                conn.Open();
                sqlCommandObject.ExecuteNonQuery();
                conn.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private byte[] ReadFile(string sPath)
        {
            byte[] data = null;
            try
            {
                FileInfo fileInfo = new FileInfo(sPath);
                long numBytes = fileInfo.Length;

                FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

                BinaryReader br = new BinaryReader(fStream);

                data = br.ReadBytes((int)numBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return data;
        }
    }
}
