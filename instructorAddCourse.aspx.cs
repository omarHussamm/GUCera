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
    public partial class instructorAddCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addCourse(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);
            try
            {
                Double price = Double.Parse(cost.Text);
                int creditHours = Int16.Parse(ch.Text);
                String cname = name.Text;

                SqlCommand addC = new SqlCommand("InstAddCourse", conn);
                addC.CommandType = CommandType.StoredProcedure;

                addC.Parameters.Add(new SqlParameter("@creditHours", creditHours));
                addC.Parameters.Add(new SqlParameter("@name", cname));
                addC.Parameters.Add(new SqlParameter("@price", price));
                addC.Parameters.Add(new SqlParameter("@instructorId", Session["user"]));



                conn.Open();
                addC.ExecuteNonQuery();
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