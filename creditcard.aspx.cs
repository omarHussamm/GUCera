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
    public partial class creditcard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

        SqlConnection conn = new SqlConnection(connStr);

        

        SqlCommand studentregproc = new SqlCommand("addCreditCard", conn);
        studentregproc.CommandType = CommandType.StoredProcedure;
            int no = Int16.Parse(number.Text);
            string cv = cvv.Text;

            String namez = name.Text;
            int id = (int)Session["user"];

            string time = date.Text;

            
            studentregproc.Parameters.Add(new SqlParameter("@number", no));
            studentregproc.Parameters.Add(new SqlParameter("@cvv", cv));

            studentregproc.Parameters.Add(new SqlParameter("@expiryDate", time ));
            studentregproc.Parameters.Add(new SqlParameter("@sid", id));


            studentregproc.Parameters.Add(new SqlParameter("@cardHolderName", namez));


            int c = 0;


          try { 

                conn.Open();
                studentregproc.ExecuteNonQuery();
                conn.Close();
                
            }
            catch (Exception ee)
            {
                Response.Write("<script>alert('something wrong happened ');</script>");

                c = -1;
            }
      if (c != -1)
      {

    Response.Write("<script>alert('CreditCard added sucessfully  ');</script>");
    number.Text = null;
    cvv.Text = null;
    date.Text = null;
                name.Text = null;
}
            }
    }
}