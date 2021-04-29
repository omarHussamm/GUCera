using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class adminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListCourses_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            conn.Open();
            Response.Redirect("ListAllCourse.aspx");
            conn.Close();
        }

        protected void NoAcceptedCourses_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            conn.Open();
            Response.Redirect("NonAcceptedCourse.aspx");
            conn.Close();
        }

        protected void AcceptCourse_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            conn.Open();
            Response.Redirect("AcceptCourseAddedByInst.aspx");
            conn.Close();
        }

        protected void CreatePromo_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            conn.Open();
            Response.Redirect("AdminCreatePromocode.aspx");
            conn.Close();
        }

        protected void IssuePromo_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            conn.Open();
            Response.Redirect("AdminIssuePromocode.aspx");
            conn.Close();
        }
    }
}