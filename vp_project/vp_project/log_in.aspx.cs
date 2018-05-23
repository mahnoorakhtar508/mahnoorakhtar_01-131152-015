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
           
        }

        protected void loginbutton_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                SqlConnection con = new SqlConnection("Data Source = ASUSPC; Initial Catalog = vp_project; Integrated Security = True");
                con.Open();
                string Checkuser = "Select count(*) from signUp where email ='" + emailTextBox.Text + "'  and password='"+passwordTextBox.Text+"' "; //checks if user entered email and password matches with that in database.
                SqlCommand cmnd = new SqlCommand(Checkuser, con);
                int temp = 0;
                temp = Convert.ToInt32(cmnd.ExecuteScalar().ToString());
                con.Close();
                if (temp == 1)
                {
                    con.Open();
                    string checkpass = "Select password from signUp where email ='" + emailTextBox.Text + "' "; //checks if for a particular email that password is correct or not.
                    SqlCommand cmd = new SqlCommand(checkpass, con);
                    string password = cmd.ExecuteScalar().ToString();
                    if (password == passwordTextBox.Text) //password in database and user entered matches or not
                    {
                        Session["New"] = emailTextBox.Text;
                        Response.Write("login Successful");

                    }
                    else
                    {
                        Response.Write("please write correct password");
                    }
                }
                else
                {
                    Response.Write("email  is not written correctly");
                }
                con.Close();
                emailTextBox.Text = "";
                passwordTextBox.Text = "";
            }
        }
    }
}