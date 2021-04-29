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
    public partial class Viewfinalgrade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void register(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand studentregproc = new SqlCommand("viewAssignGrades", conn);
            studentregproc.CommandType = CommandType.StoredProcedure;

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
                SqlParameter finalgrade = studentregproc.Parameters.Add("@assignGrade", SqlDbType.Decimal);
                finalgrade.Direction = ParameterDirection.Output;

                SqlParameter sucess = studentregproc.Parameters.Add("@sucess", SqlDbType.Int);
                sucess.Direction = ParameterDirection.Output;

                SqlParameter sucess2 = studentregproc.Parameters.Add("@sucess2", SqlDbType.Int);
                sucess2.Direction = ParameterDirection.Output;


                SqlParameter sucess4 = studentregproc.Parameters.Add("@sucess4", SqlDbType.Int);
                sucess4.Direction = ParameterDirection.Output;


               
                conn.Open();
                studentregproc.ExecuteNonQuery();
                conn.Close();
                

                 if (finalgrade.Value.ToString() == ""&& sucess.Value.ToString() =="1" )
                {

                    Label name1 = new Label();
                    name1.Text = " your assignment grade is : Not Added on the system yet  " + "<br>";
                    form1.Controls.Add(name1);
                }

                else if (sucess.Value.ToString() == "1")
                {
                    Label name1 = new Label();
                    name1.Text = " your assignment grade is : " + finalgrade.Value + "<br>";
                    form1.Controls.Add(name1);
                }
                
                if (sucess2.Value.ToString() == "1")
                {
                    Response.Write("<script>alert('not enrolled in this course , please check the course id again ');</script>");
                }
                else if (sucess.Value.ToString() == "0")
                {
                    Response.Write("<script>alert('wrong assignment number or type , please check  your inputs again  and check tht you submitted the assignment ');</script>");

                }
           

                }
                    catch (FormatException)
                 {
                   String strErrorDesc = "Invalid Format!";
                 Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " ');</script>");

                            }
            


               



            









        }



    }
}