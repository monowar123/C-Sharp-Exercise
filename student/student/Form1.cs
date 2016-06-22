using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace student
{
    public partial class Form1 : Form
    {
        DataTable DataTableObj = new DataTable();
        DBconnection DBconnectionObj = new DBconnection();
        int i = -1;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Student Information";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lsQuety = "INSERT INTO table_student VALUES ('" + inputname.Text + "','" + inputid.Text + "','" + dept.SelectedItem.ToString() + "','" + session.SelectedItem.ToString() + "')";
            DataTableObj = DBconnectionObj.InsertDataToDatavase(lsQuety);
            if (DataTableObj != null)
            {
                try
                {
                    i++;

                    string vname, vid, vsession, vdept;
                    vname = inputname.Text;
                    vid = inputid.Text;
                    vdept = dept.SelectedItem.ToString();
                    vsession = session.SelectedItem.ToString();

                    listView1.Items.Add(vname);
                    listView1.Items[i].SubItems.Add(vid);
                    listView1.Items[i].SubItems.Add(vdept);
                    listView1.Items[i].SubItems.Add(vsession);
                }
                catch
                {
                    inputname.Text = "error";
                    i = -1;
                }
            }
        }
    }
}
