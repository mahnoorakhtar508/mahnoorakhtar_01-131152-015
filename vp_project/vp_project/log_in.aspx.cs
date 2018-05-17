using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace vp_project
{
    public partial class log_in : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                SqlConnection con = new SqlConnection("Data Source = ASUSPC; Initial Catalog = vp_project; Integrated Security = True");
                con.Open();
                string Checkuser = "Select count(*) from sign-up where email ='" + emailTextBox.Text + "'   ";
                SqlCommand cmnd = new SqlCommand(Checkuser, con);
                int temp = 0;
                temp = Convert.ToInt32(cmnd.ExecuteScalar().ToString());
                if (temp == 1)
                {
                    con.Open();
                    string checkpass = "Select password from sign-up where email ='" + emailTextBox.Text + "' ";
                }
                con.Close();

            }
        }

        protected void loginbutton_Click(object sender, EventArgs e)
        {

        }
    }
}