using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class NonAcceptedCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            SqlCommand NonAcceptedCourses = new SqlCommand("AdminViewNonAcceptedCourses", conn);
            NonAcceptedCourses.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr = NonAcceptedCourses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String name = rdr.GetString(rdr.GetOrdinal("name"));
                int credithours = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
                decimal price = rdr.GetDecimal(rdr.GetOrdinal("price"));
                String content = rdr.GetString(rdr.GetOrdinal("content"));

                Label Course = new Label();
                Course.Text = "Non Accepted Courses:" + "<br>" + " Name: " + name + " Credit Hours: " + credithours + " Price: " + price + " Content: " + content + "<br>";
                form1.Controls.Add(Course);
            }

        }
    }
}