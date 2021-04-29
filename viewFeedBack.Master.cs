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
    public partial class viewFeedBack1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string getWhileLoopData()
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            SqlCommand feed = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse", conn);
            string htmlStr = "";

            feed.CommandType = CommandType.StoredProcedure;

            feed.Parameters.Add(new SqlParameter("@instrId", Session["user"]));
            feed.Parameters.Add(new SqlParameter("@cid", Session["courseID"]));

            conn.Open();
            SqlDataReader rdr = feed.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String comment = rdr.GetString(rdr.GetOrdinal("comment"));
                int num = rdr.GetInt32(rdr.GetOrdinal("number"));
                int likes = (rdr.GetInt32(rdr.GetOrdinal("numberOfLikes")));
                htmlStr += "<tr><td>" + num + "</td><td>" + comment + "</td><td>" + likes + "</td></tr>";
            }

            conn.Close();
            return htmlStr;
        }
    }
}