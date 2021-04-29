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
    public partial class promocode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            int id = (int)Session["user"];

            SqlCommand studentregproc = new SqlCommand("viewPromocode", conn);
            studentregproc.CommandType = CommandType.StoredProcedure;
            studentregproc.Parameters.Add(new SqlParameter("@sid", id));

            conn.Open();
            SqlDataReader rdr = studentregproc.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                string courseName = rdr.GetString(rdr.GetOrdinal("code"));
                Label name = new Label();
                name.Text = courseName + "<br >";
                form1.Controls.Add(name);

            }

            Response.Write("Here is your Promocode ");
        }
    }
}