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
    public partial class AdminIssuePromocode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Issue_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(@connStr);

            int sid = Int16.Parse(StudentId.Text);
            String code = Code.Text;


            SqlCommand IssuePromo = new SqlCommand("AdminIssuePromocodeToStudent", conn);
            IssuePromo.CommandType = CommandType.StoredProcedure;

            IssuePromo.Parameters.Add(new SqlParameter("@sid", sid));
            IssuePromo.Parameters.Add(new SqlParameter("@pid", code));


            conn.Open();
            IssuePromo.ExecuteNonQuery();
            conn.Close();
        }
    }
}