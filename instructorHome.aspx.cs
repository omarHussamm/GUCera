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
    public partial class instructorHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void mob_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            String number = mobileNo.Text;

            SqlCommand add = new SqlCommand("addMobile", conn);
            add.CommandType = CommandType.StoredProcedure;

            add.Parameters.Add(new SqlParameter("@ID", Session["user"]));
            add.Parameters.Add(new SqlParameter("@mobile_number", number));

            SqlParameter sucess = add.Parameters.Add("@sucess", SqlDbType.Int);
            sucess.Direction = ParameterDirection.Output;

            conn.Open();
            try
            {
                add.ExecuteNonQuery();
            if (sucess.Value.ToString() == "0")
            {
                Response.Write("<script>alert('Mobile number already added , please check the number added again');</script>");

            }
            else
                {
                    Response.Write("<script>alert('Mobile number added sucessfully ');</script>");

                }


            }
             catch (Exception ee)
            {
               Response.Write("<script>alert('Mobile number already added , please check your inputs again   ');</script>");

             }
    conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("instructorAddCourse.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("instructorAddAssignment.aspx");
        }

        protected void viewGarde_Click(object sender, EventArgs e)
        {
            try
            {
                Session["courseID"] = Int16.Parse(cid.Text);
            }
            catch (FormatException)
            {
                String strErrorDesc = "Invalid Course ID!";
                Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " ');</script>");
                return;
            }
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);


            SqlCommand instteachcours = new SqlCommand("instteachcours", conn);
            instteachcours.CommandType = CommandType.StoredProcedure;
            instteachcours.Parameters.Add(new SqlParameter("@courseid", Session["courseID"]));
            instteachcours.Parameters.Add(new SqlParameter("@insid", Session["user"]));
            SqlParameter success = instteachcours.Parameters.Add("@success", System.Data.SqlDbType.Int);
            success.Direction = ParameterDirection.Output;

            conn.Open();
            instteachcours.ExecuteNonQuery();
            conn.Close();

            if (success.Value.ToString() != "1")
            {

                String strErrorDesc = "You don't teach this course!";
                Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " ');</script>");
               
            }else
            Response.Redirect("viewGrade.aspx");
        }

        protected void viewFeedBack_Click(object sender, EventArgs e)
        {
            try
            {
                Session["courseID"] = Int16.Parse(cid1.Text);
            }
            catch (FormatException)
            {
                String strErrorDesc = "Invalid Course ID!";
                Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " ');</script>");
                return;
            }
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);


            SqlCommand instteachcours = new SqlCommand("instteachcours", conn);
            instteachcours.CommandType = CommandType.StoredProcedure;
            instteachcours.Parameters.Add(new SqlParameter("@courseid", Session["courseID"]));
            instteachcours.Parameters.Add(new SqlParameter("@insid", Session["user"]));
            SqlParameter success = instteachcours.Parameters.Add("@success", System.Data.SqlDbType.Int);
            success.Direction = ParameterDirection.Output;

            conn.Open();
            instteachcours.ExecuteNonQuery();
            conn.Close();

            if (success.Value.ToString() != "1")
            {

                String strErrorDesc = "You don't teach this course!";
                Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " ');</script>");
            }else

            Response.Redirect("viewFeedBack.aspx");
        }

        protected void certificate_Click(object sender, EventArgs e)
        {
            Response.Redirect("issueCertificate.aspx");
        }
    }
}