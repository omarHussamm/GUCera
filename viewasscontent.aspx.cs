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
    public partial class viewasscontent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand courses = new SqlCommand("viewAssign", conn);
            courses.CommandType = CommandType.StoredProcedure;
            Console.WriteLine(Session["user"]);

            int id = (int)Session["user"];

            int y = (int)Session["course"];

            courses.Parameters.Add(new SqlParameter("@courseId", id));
            courses.Parameters.Add(new SqlParameter("@sid", y));

            SqlParameter sucess = courses.Parameters.Add("@sucess", SqlDbType.Int);
            sucess.Direction = ParameterDirection.Output;




            conn.Open();
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                string courseName = rdr.GetString(rdr.GetOrdinal("type"));
                Label name = new Label();
                name.Text = "type : " + courseName + '\t';
                form1.Controls.Add(name);

                int assno = rdr.GetInt32(rdr.GetOrdinal("number"));
                Label name1 = new Label();
                name1.Text = " number : " + assno.ToString() + '\t';
                form1.Controls.Add(name1);


                int full = rdr.GetInt32(rdr.GetOrdinal("fullgrade"));
                Label name2 = new Label();
                name2.Text = " fullgrade : " + full.ToString() + '\t';
                form1.Controls.Add(name2);


                decimal weigh = rdr.GetDecimal(rdr.GetOrdinal("weight"));
                Label name3 = new Label();
                name3.Text = " weight : " + weigh.ToString() + '\t';
                form1.Controls.Add(name3);

                DateTime t = rdr.GetDateTime(rdr.GetOrdinal("deadline"));
                Label name4 = new Label();
                name4.Text = " deadline : " + t.ToString() + '\t';
                form1.Controls.Add(name4);



                string c = rdr.GetString(rdr.GetOrdinal("content"));
                Label name5 = new Label();
                name5.Text = "content : " + c + "<br >";
                form1.Controls.Add(name5);



            }

        }

     
        
    }
}