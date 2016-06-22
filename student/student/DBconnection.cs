using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace student
{
    class DBconnection
    {
        OleDbConnection OleDbConnectionObj = new OleDbConnection();
        string lsconnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=j:\Programme\C#\student\student_info.accdb;Persist Security Info=False";

        public DataTable InsertDataToDatavase(string asQuery)
        {
            OleDbConnectionObj.ConnectionString = lsconnectionString;
            OleDbConnectionObj.Open();
            OleDbDataAdapter OleDbDataAdapterObj=new OleDbDataAdapter (asQuery ,OleDbConnectionObj);
            DataTable DataTableObj = new DataTable();
            OleDbDataAdapterObj.Fill(DataTableObj);
            OleDbConnectionObj.Close();
            return DataTableObj;
        }
    }
}
