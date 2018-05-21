using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace vp_project
{
    public partial class sign_up : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmnd = new SqlCommand();
        DataTable dt;
        DataSet ds = new DataSet();
        SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {
     
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source = ASUSPC; Initial Catalog = vp_project; Integrated Security = True");
            con.Open();
            string query = " Select  * from signUp where email='" + emailTextBox.Text.ToString() + "'";
            cmnd = new SqlCommand(query, con);
            {
               cmnd.Connection = con;
                reader = cmnd.ExecuteReader();
                if (reader.Read())
                {
                    Response.Write("Record already exists");

                }
                else
                {
                    try
                    {

                        {
                            cmnd = new SqlCommand("insert into [signUp]" + "(First_name,Last_name,email,password,confirm_password) values(@First_name,@Last_name,@email,@password,@confirm_password) ", con);
                            cmnd.Parameters.AddWithValue("@First_name", first_nameTextBox.Text);
                            cmnd.Parameters.AddWithValue("@Last_name", last_nameTextBox.Text);
                            cmnd.Parameters.AddWithValue("@email", emailTextBox.Text);
                            cmnd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                            cmnd.Parameters.AddWithValue("@confirm_password", confirm_passwordTextBox.Text);

                            cmnd.ExecuteNonQuery();
                            Response.Write("registration successful");
                            con.Close();
                        }


                    }

                    catch (Exception ex)
                    {
                        throw ex;
                    }


                }

                reader.Close();
                reader.Dispose();
            }

           con.Close();




           



            first_nameTextBox.Text = "";
            last_nameTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text="";
            confirm_passwordTextBox.Text = "";


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}