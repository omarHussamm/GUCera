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
    public partial class Myprofile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand courses = new SqlCommand("viewMyProfile", conn);
            courses.CommandType = CommandType.StoredProcedure;
            int id = (int)Session["user"];
            courses.Parameters.Add(new SqlParameter("@id", id));

            conn.Open();
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                string Name = rdr.GetString(rdr.GetOrdinal("firstName"));
                Label name = new Label();
                name.Text = " Name : " + Name + " " + '\t';
                form1.Controls.Add(name);

                string Name2 = rdr.GetString(rdr.GetOrdinal("lastName"));
                Label name1 = new Label();
                name1.Text = Name2 + "<br >";
                form1.Controls.Add(name1);




                string Name3 = rdr.GetString(rdr.GetOrdinal("password"));
                Label name2 = new Label();
                name2.Text = " Password  : " + Name3 + "<br >";
                form1.Controls.Add(name2);





                string Name4 = rdr.GetString(rdr.GetOrdinal("email"));
                Label name3 = new Label();
                name3.Text = " email  : " + Name4 + "<br >";
                form1.Controls.Add(name3);



                string Name5 = rdr.GetString(rdr.GetOrdinal("address"));
                Label name4 = new Label();
                name4.Text = " address  : " + Name5 + "<br >";
                form1.Controls.Add(name4);




                byte[] gender = (byte[])rdr["gender"];


                Label name5 = new Label();
                if (gender[0] == 1)
                {
                    name5.Text = "gender : Female " + "<br>";
                    form1.Controls.Add(name5);
                }
                else
                {


                    name5.Text = "gender : Male " + "<br>";
                    form1.Controls.Add(name5);
                }


                int  name6 = (int)Session["user"];
                Label name7 = new Label();
                name7.Text = "Id : " + name6 + "<br >";
                    form1.Controls.Add(name7);





            }

        }
    }
}



