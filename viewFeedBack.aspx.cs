using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class viewFeedBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            SqlCommand feed = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse", conn);

            feed.CommandType = CommandType.StoredProcedure;

            feed.Parameters.Add(new SqlParameter("@instrId", Session["user"]));
            feed.Parameters.Add(new SqlParameter("@cid", Session["courseID"]));

            DataTable dt = new DataTable();
            dt.Columns.Add("Comment Number");
            dt.Columns.Add("Comment");
            dt.Columns.Add("Number of Likes");


            conn.Open();
            SqlDataReader rdr = feed.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String comment = rdr.GetString(rdr.GetOrdinal("comment"));
                int num = rdr.GetInt32(rdr.GetOrdinal("number"));
                int likes = (rdr.GetInt32(rdr.GetOrdinal("numberOfLikes")));
                dt.Rows.Add(num, comment, likes);
            }
            //Building an HTML string.
            StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table id=\"customers\">");

            //Building the Header row.
            html.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                html.Append("<th>");
                html.Append(column.ColumnName);
                html.Append("</th>");
            }
            html.Append("</tr>");

            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }

            //Table end.
            html.Append("</table>");

            //Append the HTML string to Placeholder.
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }

    }
}