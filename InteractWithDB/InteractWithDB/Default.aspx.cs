using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace InteractWithDB
{
    public partial class _Default : System.Web.UI.Page
    {        
        public ServiceReference1.GateWayServiceClient cObj = new ServiceReference1.GateWayServiceClient();

        List<SqlParameter> parameter = new List<SqlParameter>();

        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = cObj.testMessage();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string insertString = @"insert into [PageInfo] (pageId, pageContent) values(@pageId, @pageContent)";

                parameter.Add(new SqlParameter("@pageId", "Hello"));
                parameter.Add(new SqlParameter("@pageContent", myEditor.Text));

                //bool pp = cObj.InsertData(insertString, parameter);

                string sqlString = "select * from PageInfo";
                DataTable dtObject = new DataTable();
                dtObject = cObj.SelectData(sqlString);

                GridView1.DataSource = dtObject;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
    }
}
