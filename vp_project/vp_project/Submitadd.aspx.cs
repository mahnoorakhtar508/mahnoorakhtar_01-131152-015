using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
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
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/images/" + FileUpload1.FileName)); //saves a file to images folder.
                Response.Write("file saved in images folder");
            }
            else
            {
                Response.Write("select image to upload");
            }
            cmnd.Parameters.AddWithValue("@image", "images\\" + FileUpload1.FileName);
            //string filr = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
            //cmnd.Parameters.AddWithValue("@image",filr);
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