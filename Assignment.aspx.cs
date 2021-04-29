using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Assignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void viewass(object sender, EventArgs e)
        {
            Response.Redirect("viewmyass.aspx");
        }
        protected void submitass(object sender, EventArgs e)
        {
            Response.Redirect("Sumbitmyass.aspx");
        }
        protected void viewassgrade(object sender, EventArgs e)
        {
            Response.Redirect("Viewfinalgrade.aspx");
        }
    }
}