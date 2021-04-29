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
    public partial class AdminCreatePromocode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreatePromo_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            String code = Code.Text;
            DateTime issue = DateTime.Parse(Issuedate.Value);
            DateTime expiry = DateTime.Parse(Expirydate.Value);
            Decimal discount = decimal.Parse(Discount.Text);
            int id = Int16.Parse(AdminId.Text);

            SqlCommand AdminPromo = new SqlCommand("AdminCreatePromocode", conn);
            AdminPromo.CommandType = CommandType.StoredProcedure;

            AdminPromo.Parameters.Add(new SqlParameter("@code", code));
            AdminPromo.Parameters.Add(new SqlParameter("@isuueDate", issue));
            AdminPromo.Parameters.Add(new SqlParameter("@expiryDate", expiry));
            AdminPromo.Parameters.Add(new SqlParameter("@discount", discount));
            AdminPromo.Parameters.Add(new SqlParameter("@adminId", id));


            conn.Open();
            AdminPromo.ExecuteNonQuery();
            conn.Close();
        }
    }
}