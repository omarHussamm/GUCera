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
    public partial class telephone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login(object sender , EventArgs e)
        {


            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand studentregproc = new SqlCommand("addMobile", conn);
            studentregproc.CommandType = CommandType.StoredProcedure;

           
            int id = (int)Session["user"];
            studentregproc.Parameters.Add(new SqlParameter("@ID", id));

            String number = mob.Text;
            studentregproc.Parameters.Add(new SqlParameter("@mobile_number", number));

            SqlParameter sucess = studentregproc.Parameters.Add("@sucess", SqlDbType.Int);
            sucess.Direction = ParameterDirection.Output;


            try
            {
                conn.Open();
                studentregproc.ExecuteNonQuery();


                conn.Close();


                if (sucess.Value.ToString() == "0")
                {
                    Response.Write("<script>alert('Mobile number already added , please check the number added again');</script>");

                }
                else
                {
                    Response.Write("<script>alert('Mobile number added suessfully ');</script>");
                    mob.Text = null;
                }


            }
             catch ( Exception ee)
            {
               Response.Write("<script>alert('Mobile number already added , please check your inputs again   ');</script>");

             }
        }
    }
}