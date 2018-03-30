using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentprofilegui
{
    public partial class searchingName : Form
    {
     
        public searchingName()
        {
            InitializeComponent();
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Search_data obj = new Search_data();
            string[] Data_array = obj.searchbyname(searchnametxt.Text, "studentrecord.txt").Split('\n');

            for (int i = 0; i < Data_array.Length; i++)
            {
                list.Items.Add(Data_array[i]);
                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void name_search_label_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchingdata obj = new searchingdata();
            obj.Show(); 
           
        }
    }
}
