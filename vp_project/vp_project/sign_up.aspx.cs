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
            //if (IsPostBack)
            //{
            //    SqlConnection con = new SqlConnection("Data Source = ASUSPC; Initial Catalog = vp_project; Integrated Security = True");
            //    con.Open();
            //    string Checkuser = "Select count(*) from sign-up where First_name='" + first_nameTextBox.Text + "' and Last_name='" + last_nameTextBox.Text + "'  ";
            //    SqlCommand cmnd = new SqlCommand(Checkuser, con);
            //    int temp = 0;
            //      temp=  Convert.ToInt32(cmnd.ExecuteScalar().ToString());
            //    if (temp == 1)
            //    {
            //        Response.Write("user already exists");
            //    }
            //    con.Close();

            //}
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source = ASUSPC; Initial Catalog = vp_project; Integrated Security = True");
            con.Open();
            string query = " Select  Count(*) from sign-up where email('" + emailTextBox.Text + "')";
            cmnd = new SqlCommand(query, con);
            {
               cmnd.Connection = con;
                reader = cmnd.ExecuteReader();
                if (reader.Read())
                {
                    Response.Write("please enter required data");

                }
                else
                {
                    try
                    {

                        {
                            cmnd = new SqlCommand("insert into [sign-up]" + "(First_name,Last_name,email,password,confirm_password) values(@First_name,@Last_name,@email,@password,@confirm_password) ", con);
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




            //con = new SqlConnection("Data Source = ASUSPC; Initial Catalog = vp_project; Integrated Security = True");
            //con.Open();
            //if (first_nameTextBox.Text == "" || last_nameTextBox.Text == "" || emailTextBox.Text == "" || passwordTextBox.Text == "" || confirm_passwordTextBox.Text == "")
            //{

            //    Response.Write("please enter required data");

            //}
            //else
            //{


            //    cmnd = new SqlCommand("Select  * from sign-up where email  '" + emailTextBox.Text + "' ", con);
            //    SqlDataAdapter sda = new SqlDataAdapter(cmnd);

            //    sda.Fill(ds);
            //    int i = ds.Tables[0].Rows.Count;
            //    if (i > 0)
            //    {
            //        Response.Write("email already exists ..please enter a unique one ");
            //        ds.Clear();
            //    }

            //    else
            //    {

            //        try
            //        {

            //            {
            //                cmnd = new SqlCommand("insert into [sign-up]" + "(First_name,Last_name,email,password,confirm_password) values(@First_name,@Last_name,@email,@password,@confirm_password) ", con);
            //                cmnd.Parameters.AddWithValue("@First_name", first_nameTextBox.Text);
            //                cmnd.Parameters.AddWithValue("@Last_name", last_nameTextBox.Text);
            //                cmnd.Parameters.AddWithValue("@email", emailTextBox.Text);
            //                cmnd.Parameters.AddWithValue("@password", passwordTextBox.Text);
            //                cmnd.Parameters.AddWithValue("@confirm_password", confirm_passwordTextBox.Text);

            //                cmnd.ExecuteNonQuery();
            //                Response.Write("registration successful");
            //                con.Close();
            //            }


            //        }

            //        catch (Exception ex)
            //        {
            //            throw ex;
            //        }
            //    }
            //}




            first_nameTextBox.Text = "";
            last_nameTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text="";
            confirm_passwordTextBox.Text = "";


        }
    }
}