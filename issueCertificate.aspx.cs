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
    public partial class issueCertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                SqlConnection conn = new SqlConnection(@connStr);

                int studentID = Int16.Parse(sid.Text);
                int courseID = Int16.Parse(cid.Text);

                SqlCommand issue = new SqlCommand("InstructorIssueCertificateToStudent", conn);
                issue.CommandType = CommandType.StoredProcedure;

                issue.Parameters.Add(new SqlParameter("@insId", Session["user"]));
                issue.Parameters.Add(new SqlParameter("@sid", studentID));
                issue.Parameters.Add(new SqlParameter("@cid", courseID));
                issue.Parameters.Add(new SqlParameter("@issueDate", DateTime.Now));

                conn.Open();
                issue.ExecuteNonQuery();
                conn.Close();

                Response.Redirect("instructorHome.aspx");
            }
            catch (FormatException)
            {
                String strErrorDesc = "Invalid Format!";
                Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " ');</script>");

            }
        }
    }
}