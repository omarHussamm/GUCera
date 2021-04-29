using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void creditcard(object sender, EventArgs e)
        {
            Response.Redirect("creditcard.aspx");
        }
        protected void promocode(object sender, EventArgs e)
        {
            Response.Redirect("promocode.aspx");
        }
    }
}