using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace vp_project
{
    public partial class furniture : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = ASUSPC; Initial Catalog = vp_project; Integrated Security = True");
            con.Open();
            DataTable dt = new DataTable();
            string query = "select * from itemss where Category='Furniture' ;";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            itemList.DataSource = dt;
            itemList.DataBind();
        }
    }
}