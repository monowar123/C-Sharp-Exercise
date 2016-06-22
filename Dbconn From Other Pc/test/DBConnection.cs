using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace test
{
    public class DBConnection
    {
        private string connectionString = null;
        private SqlConnection sqlConn = null;

        public DBConnection()
        {
            connectionString = @"Data Source=192.168.10.45\SQLEXPRESS; Initial Catalog=test; User ID=sa; Password=cse";
            //sqlConn = new SqlConnection(GlobalVar.connStr);
            sqlConn = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection
        {
            get
            {
                return sqlConn;
            }
            private set
            {
            }
        }
    }
}
