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
    public partial class Submitadd : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Uploadbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = ASUSPC; Initial Catalog = vp_project; Integrated Security = True"); //connection string
            con.Open();
            SqlCommand cmnd = new SqlCommand();
            cmnd = new SqlCommand("insert into items" + "(Title,image,Description,price,status) values(@Title,@image,@Description,@price,@status) ", con);// sqlquery
            cmnd.Parameters.AddWithValue("@Title", titletextboc.Text);
            if(FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/images/" + FileUpload1.FileName)); //saves a file to images folder.
            }
            cmnd.Parameters.AddWithValue("@Last_name",FileUpload1.);
          
            cmnd.Parameters.AddWithValue("@Description", descriptiontextbx.Text); //add values from user written in text fields to database in specific coulmn 
            cmnd.Parameters.AddWithValue("@price", pricetextbox.Text);
            cmnd.Parameters.AddWithValue("@status", DropDownList1.SelectedItem.Value);
            int i = cmnd.ExecuteNonQuery();
            if (i != 0)
            {
                Response.Write("registration successful");
            }

        }
    }
}