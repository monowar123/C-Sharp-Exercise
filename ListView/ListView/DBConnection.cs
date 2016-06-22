using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace ListView
{
    class DBConnection
    {
        OleDbConnection OleDbConnectionObj = new OleDbConnection();
        string lsConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\VisualProgrammingLab\New Folder\ListView\student_info.accdb;Persist Security Info=False";

        public DataTable InsertDataToDatabase(string asQuery)
        {
            OleDbConnectionObj.ConnectionString = lsConnectionString;
            //OleDbConnectionObj.Open();

            OleDbDataAdapter OleDbDataAdapterObj = new OleDbDataAdapter(asQuery, OleDbConnectionObj);
            DataTable DataTableObj = new DataTable();
            OleDbDataAdapterObj.Fill(DataTableObj);
            
            OleDbConnectionObj.Close();
            return DataTableObj;
        }

    }
}
