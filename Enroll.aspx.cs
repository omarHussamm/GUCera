using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace GUCera
{
    public partial class Enroll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void register(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand courses = new SqlCommand("enrollInCourse", conn);
            courses.CommandType = CommandType.StoredProcedure;
            try { 

            int idd = (int)Session["user"];

            int y = Int16.Parse(cid.Text);
            int x = Int16.Parse(id.Text);

            courses.Parameters.Add(new SqlParameter("@cid", y));

            courses.Parameters.Add(new SqlParameter("@sid", idd));

            courses.Parameters.Add(new SqlParameter("@instr", x));
            
            
                conn.Open();
                courses.ExecuteNonQuery();
                conn.Close();
            }


            
            catch (FormatException)
            {
                String strErrorDesc = "Invalid Format!";
        Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " ');</script>");

            }

            catch (Exception ee)
            {

                Response.Write("<script>alert('something wrong happened  , please check your entries');</script>");
            }
        }
    }
}