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
    public partial class AcceptCourseAddedByInst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AcceptCourse_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            int Adminid = Int16.Parse(AdminId.Text);
            int Courseid = Int16.Parse(CourseId.Text);

            SqlCommand AcceptCourse = new SqlCommand("AdminAcceptRejectCourse", conn);
            AcceptCourse.CommandType = CommandType.StoredProcedure;

            AcceptCourse.Parameters.Add(new SqlParameter("@adminid", Adminid));
            AcceptCourse.Parameters.Add(new SqlParameter("@courseId", Courseid));

            conn.Open();
            AcceptCourse.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("ListAllCourse.aspx");

        }
    }
}