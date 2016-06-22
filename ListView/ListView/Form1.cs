using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {

        DataTable DataTableObj = new DataTable();
        DBConnection DBConnectionObj = new DBConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string lsQuery = "INSERT INTO student VALUES ('" + textBox1 .Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "')";

            DataTableObj = DBConnectionObj.InsertDataToDatabase(lsQuery);
            
            if (DataTableObj != null)
            {
                listView1.Items.Add(textBox1.Text);
                listView1.Items[0].SubItems.Add(textBox2.Text);
                listView1.Items[0].SubItems.Add(textBox3.Text);
            }

            //ListViewItem lvi;
            //ListViewItem.ListViewSubItem lvsi;
            ////listView1.Items.Clear();

            //lvi = new ListViewItem();
            //lvi.Text = textBox1.Text;
            ////lvi.ImageIndex = 0;
            ////lvi.Tag = textBox1.Text;

            //lvsi = new ListViewItem.ListViewSubItem();
            //lvsi.Text = textBox2.Text;
            //lvi.SubItems.Add(lvsi);

            //lvsi = new ListViewItem.ListViewSubItem();
            //lvsi.Text = textBox3.Text;
            //lvi.SubItems.Add(lvsi);

            //listView1.Items.Add(lvi);



            //listView1.Items.Add(textBox1.Text);
            ////listView1.Items.Add(
            //listView1.Items[listView1.Items.Count-1].SubItems.Add(textBox2.Text);
            //listView1.Items[listView1.Items.Count - 1].SubItems.Add(textBox3.Text);
   

        }
    }
}
