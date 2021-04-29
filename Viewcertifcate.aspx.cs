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
    public partial class Viewcertifcate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
            protected void login(object sender , EventArgs e)
            {

            

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand studentregproc = new SqlCommand("viewCertificate", conn);
            studentregproc.CommandType = CommandType.StoredProcedure;
           try {  
            
                int courseid = Int16.Parse(cid.Text);
                int id = (int)Session["user"];

                studentregproc.Parameters.Add(new SqlParameter("@cid", courseid));
                studentregproc.Parameters.Add(new SqlParameter("@sid", id));

                Session["course"] = courseid;
           
            SqlParameter sucess = studentregproc.Parameters.Add("@sucess", SqlDbType.Int);
            sucess.Direction = ParameterDirection.Output;


            


           

                conn.Open();
                studentregproc.ExecuteNonQuery();
                conn.Close();

                if (sucess.Value.ToString() == "0")
                {
                    Response.Write("<script>alert('not enrolled in course , please check course id ');</script>");
                }
                else
                {
                    //Response.Write("bla bla ");
                    Response.Redirect("certifcate.aspx");
                }


            }

            catch (FormatException)
            {
                String strErrorDesc = "Invalid Format!";
                Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " ');</script>");

            }

            catch (Exception ee)
            {
                Response.Write("<script>alert('something wrong happened ');</script>");
            }

          


        }
    }
}