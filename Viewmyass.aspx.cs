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
    public partial class Viewmyass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand loginproc = new SqlCommand("viewAssign", conn);
            loginproc.CommandType = CommandType.StoredProcedure;
            try { 

            int courseid = Int16.Parse(coursename.Text);
            int studentid = (int)Session["user"];

            

            loginproc.Parameters.Add(new SqlParameter("@courseId", courseid));
            loginproc.Parameters.Add(new SqlParameter("@sid", studentid));

            SqlParameter sucess = loginproc.Parameters.Add("@sucess", SqlDbType.Int);
            sucess.Direction = ParameterDirection.Output;

            
            

                conn.Open();
                loginproc.ExecuteNonQuery();
                conn.Close();

                if (sucess.Value.ToString() == "0")
                {
                    Response.Write("<script>alert('not enrolled in this course , please check the course id again ');</script>");
                }
                else
                {
                    Session["course"] = courseid;
                    Response.Redirect("viewasscontent.aspx");


                }


            }
            catch (FormatException)
            {
                String strErrorDesc = "Invalid Format!";
                Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " ');</script>");

            }

           // catch (Exception ee)
           // {
            //    Response.Write("<script>alert('something wrong hapened ');</script>");
          //  }

            

        }
    }
}