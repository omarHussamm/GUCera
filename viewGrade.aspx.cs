using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class viewGrade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);



            SqlCommand viewA = new SqlCommand("InstructorViewAssignmentsStudents", conn);
            viewA.CommandType = CommandType.StoredProcedure;

            viewA.Parameters.Add(new SqlParameter("@instrId", Session["user"]));
            viewA.Parameters.Add(new SqlParameter("@cid", Session["courseID"]));

            DataTable dt = new DataTable();
            dt.Columns.Add("Course ID");
            dt.Columns.Add("Student ID");
            dt.Columns.Add("Assignment Number");
            dt.Columns.Add("Assignment Type");
            dt.Columns.Add("Grade");

            conn.Open();
            SqlDataReader rdr = viewA.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                int cid = (rdr.GetInt32(rdr.GetOrdinal("cid")));
                int sid = rdr.GetInt32(rdr.GetOrdinal("sid"));
                int number = rdr.GetInt32(rdr.GetOrdinal("assignmentNumber"));
                String type = rdr.GetString(rdr.GetOrdinal("assignmenttype"));


                try
                {
                    decimal grade = rdr.GetDecimal(rdr.GetOrdinal("grade"));
                    dt.Rows.Add(cid, sid, number, type, grade);
                }
                catch (SqlNullValueException)
 
                {
                    dt.Rows.Add(cid, sid, number, type, "UNGRADED");
                }

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);



            SqlCommand gardeA = new SqlCommand("InstructorgradeAssignmentOfAStudent", conn);
            gardeA.CommandType = CommandType.StoredProcedure;
            try
            {
                gardeA.Parameters.Add(new SqlParameter("@instrId", Session["user"]));
                gardeA.Parameters.Add(new SqlParameter("@cid", Int16.Parse(courID.Text)));
                gardeA.Parameters.Add(new SqlParameter("@sid", Int16.Parse(studID.Text)));
                gardeA.Parameters.Add(new SqlParameter("@assignmentNumber", Int16.Parse(aNum.Text)));
                gardeA.Parameters.Add(new SqlParameter("@type", aType.Text));
                gardeA.Parameters.Add(new SqlParameter("@grade", Double.Parse(g.Text)));

                conn.Open();
                gardeA.ExecuteNonQuery();
                conn.Close();

                Response.Redirect("instructorHome.aspx");
            }
            catch (FormatException)
            {
                String strErrorDesc = "Invalid Format!";
                Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + strErrorDesc + " .');</script>");
            }
        }
    }
}