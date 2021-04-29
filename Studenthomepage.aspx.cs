using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Studenthomepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ass(object sender, EventArgs e)
        {
            Response.Redirect("Assignment.aspx");
        }
        protected void allcourses(object sender, EventArgs e)
        {
            Response.Redirect("courses.aspx");
        }
        protected void certificate(object sender, EventArgs e)
        {
            Response.Redirect("Viewcertifcate.aspx");
        }
        protected void mycourses(object sender, EventArgs e)
        {
            Response.Redirect("Mycourses.aspx");
        }
        protected void payment(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }

        protected void info(object sender, EventArgs e)
        {

            Response.Redirect("Myprofile.aspx");
        }
        protected void tel(object sender ,EventArgs e)
        {
            Response.Redirect("telephone.aspx");
        }
    }
}