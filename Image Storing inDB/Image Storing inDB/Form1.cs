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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=MONOWAR-PC; Initial Catalog=store_image; User ID=sa; Password=cse";
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                SqlDataAdapter data = new SqlDataAdapter("select * from image_table", conn);

                DataTable dt = new DataTable();

                data.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStoreNewImage_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            myForm.ShowDialog();                   
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Get image data from gridview column.
                byte[] imageData = (byte[])dataGridView1.Rows[e.RowIndex].Cells["picture"].Value;

                //Initialize image variable
                Image newImage;
                //Read image data into a memory stream
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);

                    //Set image variable value using memory stream.
                    newImage = Image.FromStream(ms, true);
                }

                //set picture
                pictureBox1.Image = newImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
