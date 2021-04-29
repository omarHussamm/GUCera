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
    public partial class certifcate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand courses = new SqlCommand("viewCertificate", conn);
            courses.CommandType = CommandType.StoredProcedure;

            int id = (int)Session["user"];



            int y = (int)Session["course"];



            courses.Parameters.Add(new SqlParameter("@sid", y));

            courses.Parameters.Add(new SqlParameter("@cid", id));


            SqlParameter sucess = courses.Parameters.Add("@sucess", SqlDbType.Int);
            sucess.Direction = ParameterDirection.Output;



            conn.Open();
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                DateTime courseName = rdr.GetDateTime(rdr.GetOrdinal("issueDate"));
                Label name = new Label();
                name.Text = courseName + "<br >";
                form1.Controls.Add(name);

            }
            Response.Write("Here is your certificates ");

        }
       

    }
   
}