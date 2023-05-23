using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace DataGrid
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);


            SqlDataAdapter sde = new SqlDataAdapter("Select * from users", con);
            DataSet ds = new DataSet();
            sde.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void ctl30_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}