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
    public partial class courses1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand courses = new SqlCommand("availableCourses", conn);
            courses.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                string courseName = rdr.GetString(rdr.GetOrdinal("name"));
                Label name = new Label();
                name.Text = courseName + "<br >";
                form1.Controls.Add(name);

            }
          //  Response.Write(Session["user"]);
        }
        protected void enroll(object sender, EventArgs e)
        {
            Response.Redirect("Enroll.aspx");
        }
    }
    }


