using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class ListAllCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            SqlCommand AllCourses = new SqlCommand("AdminViewAllCourses", conn);
            AllCourses.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr = AllCourses.ExecuteReader(CommandBehavior.CloseConnection);
            
            while (rdr.Read())
            {
                String name = rdr.GetString(rdr.GetOrdinal("name"));
                int credithours = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
                decimal price = rdr.GetDecimal(rdr.GetOrdinal("price"));
                String content = rdr.GetString(rdr.GetOrdinal("content"));
                Boolean accepted = false;
                try
                {
                    accepted = rdr.GetBoolean(rdr.GetOrdinal("accepted"));
                }
                catch (SqlNullValueException)
                
                {
                   
                }
                Label Course = new Label();
                Course.Text = "Courses:" + "<br>" + " Name: " + name + " Credit Hours: " + credithours + " Price: " + price + " Content: " + content + " Accepted: " + accepted + "<br>";
                form1.Controls.Add(Course);
            }
        }

        protected void AdminHome_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            conn.Open();
            Response.Redirect("adminHome.aspx");
            conn.Close();
        }
    }
}