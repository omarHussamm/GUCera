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
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submit(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand studentregproc = new SqlCommand("addFeedback", conn);
            studentregproc.CommandType = CommandType.StoredProcedure;

            try {
                int courseid = Int16.Parse(cid.Text);
                String comm = comment.Text;
                int id = (int)Session["user"];
                studentregproc.Parameters.Add(new SqlParameter("@comment", comm));


                studentregproc.Parameters.Add(new SqlParameter("@cid", courseid));
                studentregproc.Parameters.Add(new SqlParameter("@sid", id));





                SqlParameter sucess = studentregproc.Parameters.Add("@sucess", SqlDbType.Int);
                sucess.Direction = ParameterDirection.Output;




                conn.Open();



                studentregproc.ExecuteNonQuery();
                conn.Close();

                if (sucess.Value.ToString() == "0")
                {
                    Response.Write("<script>alert('not enrolled in course , please check the course id ');</script>");
                }
                else if (sucess.Value.ToString() == "1")
                {
                    Response.Write("<script>alert('Feedback added sucessfully');</script>");
                    cid.Text = null;
                    comment.Text = null;
                    

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