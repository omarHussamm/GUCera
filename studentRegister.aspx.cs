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
    public partial class studentRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

  
        protected void reg_Click(object sender, EventArgs e)
        {
            if (firstName.Text == "" || lastName.Text == "" || password.Text == "" || email.Text == "" || address.Text == "")
            {
                String strErrorDesc = "You must fill in all the inputs!";
                Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " ');</script>");

                return;
            }
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            String e_mail = email.Text;

            SqlCommand checkEmail = new SqlCommand("checkEmail", conn);
            checkEmail.CommandType = CommandType.StoredProcedure;
            checkEmail.Parameters.Add(new SqlParameter("@email", e_mail));
            SqlParameter success = checkEmail.Parameters.Add("@success", System.Data.SqlDbType.Int);
            success.Direction = ParameterDirection.Output;

            conn.Open();
            checkEmail.ExecuteNonQuery();
            conn.Close();

            if (success.Value.ToString() == "0")
            {

                String strErrorDesc = "This email is arleady taken";
                Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " ');</script>");
                return;
            }

            String first_name = firstName.Text;
            String last_name = lastName.Text;
            String pass = password.Text;
            String gen = gender.Value;
            String add = address.Text;

            SqlCommand register = new SqlCommand("studentRegister", conn);
            register.CommandType = CommandType.StoredProcedure;

            register.Parameters.Add(new SqlParameter("@first_name", first_name));
            register.Parameters.Add(new SqlParameter("@last_name", last_name));
            register.Parameters.Add(new SqlParameter("@password", pass));
            register.Parameters.Add(new SqlParameter("@email", e_mail));
            register.Parameters.Add(new SqlParameter("@gender", gen));
            register.Parameters.Add(new SqlParameter("@address", add));

            conn.Open();
            register.ExecuteNonQuery();
            conn.Close();

            SqlCommand getid = new SqlCommand("getID", conn);
            getid.CommandType = CommandType.StoredProcedure;
            getid.Parameters.Add(new SqlParameter("@email", e_mail));
            SqlParameter message = getid.Parameters.Add("@id", System.Data.SqlDbType.Int);
            message.Direction = ParameterDirection.Output;

            conn.Open();
            getid.ExecuteNonQuery();
            conn.Close();

            ClientScript.RegisterStartupScript(GetType(), "alert", "alert('"+"Your id is" + message.Value.ToString() + "'); window.location.href = 'login.aspx'", true);
        }
    }
}