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
    public partial class Sumbitmyass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void register(object sender, EventArgs e)
        {
            int x = 0;
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand studentregproc = new SqlCommand("submitAssign", conn);
            studentregproc.CommandType = CommandType.StoredProcedure;

            // add try and catch here // 

            try
            {
                int courseid = Int16.Parse(cid.Text);
                int assno = Int16.Parse(number.Text);

                String asstype = type.Text;
                int id = (int)Session["user"];


                studentregproc.Parameters.Add(new SqlParameter("@assignnumber", assno));
                studentregproc.Parameters.Add(new SqlParameter("@assignType", asstype));

                studentregproc.Parameters.Add(new SqlParameter("@cid", courseid));
                studentregproc.Parameters.Add(new SqlParameter("@sid", id));






                SqlParameter sucess = studentregproc.Parameters.Add("@sucess", SqlDbType.Int);
                sucess.Direction = ParameterDirection.Output;



                SqlParameter sucess2 = studentregproc.Parameters.Add("@sucess2", SqlDbType.Int);
                sucess2.Direction = ParameterDirection.Output;

                SqlParameter sucess3 = studentregproc.Parameters.Add("@sucess3", SqlDbType.Int);
                sucess3.Direction = ParameterDirection.Output;


                conn.Open();

                studentregproc.ExecuteNonQuery();
              

                conn.Close();


                if (sucess.Value.ToString() == "1")
                {
                    Response.Write("<script>alert('not enrolled in this course , please check the course id again ');</script>");
                }

               






                else if (sucess2.Value.ToString() == "1")
                {

                    Response.Write("<script>alert('Assignment sumbitted sucessfully ');</script>");
                }

            }
            catch (FormatException)
            {
                String strErrorDesc = "Invalid Format!";
                Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " ');</script>");

            }


            catch (Exception ee)
            {






                   Response.Write("<script>alert('Assignment already submitted  or invalid Assignmnet number or type  , please check your inputs again ');</script>");





            
            }




            }

        }
}