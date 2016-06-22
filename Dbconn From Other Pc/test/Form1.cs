using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string st_path = Application.StartupPath;
            //string path = @"C:\Program Files\Monowar\setup1\config.xml";

            XmlTextReader reader = new XmlTextReader(st_path + @"..\..\..\config.xml");   // for developing
            //XmlTextReader reader = new XmlTextReader(st_path + @"\config.xml");  // use after install

            MessageBox.Show(st_path);
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    GlobalVar.connStr = reader.Value;
                    //MessageBox.Show(reader.Value);
                    break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != string.Empty && txtName.Text != string.Empty &&  txtDept.Text != string.Empty && txtDist.Text != string.Empty)
                {
                    string str = "insert into [student] (st_id, st_name, dept, dist) values(@st_id, @st_name, @dept, @dist)";
                    GateWay gateWay = new GateWay();
                    List<SqlParameter> parameter = new List<SqlParameter>();

                    parameter.Add(new SqlParameter("@st_id", txtId.Text));
                    parameter.Add(new SqlParameter("@st_name", txtName.Text));
                    parameter.Add(new SqlParameter("@dept", txtDept.Text));
                    parameter.Add(new SqlParameter("@dist", txtDist.Text));
                    
                    if (gateWay.InsertData(str, parameter))
                    {
                        MessageBox.Show("Inserted");
                        txtId.Text = string.Empty;
                        txtName.Text = string.Empty;
                        txtDept.Text = string.Empty;
                        txtDist.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Some Error");
                    }
                }
                else
                {
                    MessageBox.Show("Field should not be empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            GateWay gateWay = new GateWay();
            string str = "select * from student";
            try
            {
                dataTable = gateWay.SelectData(str);
                dataGridView1.DataSource = dataTable;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
