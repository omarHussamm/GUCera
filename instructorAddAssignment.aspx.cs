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
    public partial class instructorAddAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            try
            {

                int courseID = Int16.Parse(cid.Text);
                int num = Int16.Parse(number.Text);
                int grade = Int16.Parse(fullgrade.Text);
                Double w = Double.Parse(weight.Text);
                DateTime date = DateTime.Parse(deadLineTime.Value);
                String c = content.Text;
                String aType = type.Text;

                SqlCommand addA = new SqlCommand("DefineAssignmentOfCourseOfCertianType", conn);
                addA.CommandType = CommandType.StoredProcedure;

                addA.Parameters.Add(new SqlParameter("@cid", courseID));
                addA.Parameters.Add(new SqlParameter("@type", aType));
                addA.Parameters.Add(new SqlParameter("@number", num));
                addA.Parameters.Add(new SqlParameter("@fullGrade", grade));
                addA.Parameters.Add(new SqlParameter("@weight", w));
                addA.Parameters.Add(new SqlParameter("@deadline", date));
                addA.Parameters.Add(new SqlParameter("@content", c));
                addA.Parameters.Add(new SqlParameter("@instId", Session["user"]));



                conn.Open();
                addA.ExecuteNonQuery();
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