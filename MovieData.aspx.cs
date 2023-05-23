using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MovieDB
{
    public partial class MovieData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MovieConnectionString"].ConnectionString);
                conn.Open();
                string insertQuery = "insert into movie(name,director,year,type) values (@name,@director,@year,@type)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@Id", DBNull.Value);
                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@director", TextBox2.Text);
                cmd.Parameters.AddWithValue("@year", TextBox3.Text);
                cmd.Parameters.AddWithValue("@type", TextBox4.Text);
                cmd.ExecuteNonQuery();

                Response.Write("Movie added Successfully!!!thank you");

                conn.Close();

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }

        }
        protected void SqlDataSource1_Selecting1(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

       
    }
}