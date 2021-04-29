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
    public partial class Mycourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand courses = new SqlCommand("getcoursename", conn);
            courses.CommandType = CommandType.StoredProcedure;
            int id = (int)Session["user"];
            courses.Parameters.Add(new SqlParameter("@sid", id));
            conn.Open();
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                string courseName = rdr.GetString(rdr.GetOrdinal("name"));
                Label name = new Label();
                name.Text = courseName + '\t';
                form1.Controls.Add(name);


                int courseid = rdr.GetInt32(rdr.GetOrdinal("id"));
                Label name1 = new Label();
                name1.Text = courseid + "<br >";
                form1.Controls.Add(name1);


            }
        }
        protected void addfeedback(object sender, EventArgs e)
        {
            Response.Redirect("Feedback.aspx");
        }
    }
}