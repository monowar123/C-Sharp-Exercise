using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DataGridView_Example
{
    public partial class Form1 : Form
    {
        DataGridView dgvStudents;
        DataSet myDataSet;
        DataTable myDataTable;
        DataColumn colFirstName;
        DataColumn colLastName;
        DataColumn colGender;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Students Records";
            dgvStudents = new DataGridView();           //allocate memory for data grid view
            dgvStudents.Location = new Point(12, 12);
            this.Controls.Add(dgvStudents);     //add the control

            //create data column
            colFirstName = new DataColumn("First Name");
            colLastName = new DataColumn("Last Name");
            colGender = new DataColumn("Gender");            

            myDataTable = new DataTable("Student Registration"); //allocate memory for data table

            //add data columns to the data table
            myDataTable.Columns.Add(colFirstName);
            myDataTable.Columns.Add(colLastName);
            myDataTable.Columns.Add(colGender);            

            myDataSet = new DataSet("High School"); //allocate memory for dataset
            myDataSet.Tables.Add(myDataTable);  //add datatable to dataset

            //create a datarow for myDataTable and assign value for them
            DataRow rowStudent = myDataTable.NewRow();
           
            rowStudent["First Name"] = "Monowarul";
            rowStudent["Last Name"] = "Islam";
            rowStudent["Gender"] = "Male";

            myDataTable.Rows.Add(rowStudent); // add data row to the data table

            object[] arrRecord = { "Nasir", "Uddin", "Male" };
            myDataTable.Rows.Add(arrRecord);    //add an array of records

            object[] arrStudent = { "Toushar", "Kumar", "Male" };
            rowStudent = myDataTable.NewRow();
            rowStudent.ItemArray = arrStudent;
            myDataTable.Rows.Add(rowStudent);

            dgvStudents.DataSource = myDataSet; //assign datasource to the data grid view
            //assign the name of the datatable to the data grid view
            dgvStudents.DataMember = "Student Registration";

            //myDataSet.AcceptChanges();  // used to accept change to the data grid view
            // myDataSet.RejectChanges();  //used to reject change to the data grid view
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowCollection drCollection = myDataTable.Rows;
            MessageBox.Show(drCollection.Count.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fileStreamObject = new FileStream("registration.xml", FileMode.Create, FileAccess.Write);
                myDataSet.WriteXml(fileStreamObject);
                MessageBox.Show("Saved succesfully");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (File.Exists("registration.xml"))
            {
                myDataSet.ReadXml("registration.xml");
                dgvStudents.DataSource = myDataSet;
                dgvStudents.DataMember = "Student Registration";
            }
        }
        
    }
}
