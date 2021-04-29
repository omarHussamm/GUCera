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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void login(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);
            if (username.Text == "" || password.Text == "" )
            {
                String strErrorDesc = "You did not type your ID or Password!";
                Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " ');</script>");

            }
            else
            {
                int id = 0;
                try
                {
                    id = Int16.Parse(username.Text);
                }
                catch (FormatException)
                {

                    String strErrorDesc = "Invalid format for id!";
                    Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " ');</script>");

                }
                String pass = password.Text;

                SqlCommand loginproc = new SqlCommand("userLogin", conn);
                loginproc.CommandType = CommandType.StoredProcedure;

                loginproc.Parameters.Add(new SqlParameter("@ID", id));
                loginproc.Parameters.Add(new SqlParameter("@password", pass));

                SqlParameter success = loginproc.Parameters.Add("@Success", System.Data.SqlDbType.Int);
                SqlParameter type = loginproc.Parameters.Add("@Type", System.Data.SqlDbType.Int);

                success.Direction = ParameterDirection.Output;
                type.Direction = ParameterDirection.Output;

                conn.Open();
                loginproc.ExecuteNonQuery();
                conn.Close();
                if (success.Value.ToString() == "1")
                {
                    Session["user"] = id;
                    if (type.Value.ToString() == "2")

                        Response.Redirect("Studenthomepage.aspx");
                    else if (type.Value.ToString() == "1")
                        Response.Redirect("adminHome.aspx");
                    else
                        Response.Redirect("instructorHome.aspx");

                }
                else

                {

                    String strErrorDesc = "Wrong id or password";
                    Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " .');</script>");
                }
            }


        }

    }
}