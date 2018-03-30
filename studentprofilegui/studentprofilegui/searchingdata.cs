using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentprofilegui
{
    public partial class searchingdata : Form
    {
        public searchingdata()
        {
            InitializeComponent();
        }

        private void namesearchbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchingName obj = new searchingName();
            obj.Show();
        }

        private void searchingidbtn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchingbyid search = new searchingbyid();
            search.Show();
        }

        private void searchingsemesterbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_by_Semester search = new Search_by_Semester();
            search.Show();
        }

        private void back_main_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstwindow main = new firstwindow();
            main.Show();
        }
    }
}
