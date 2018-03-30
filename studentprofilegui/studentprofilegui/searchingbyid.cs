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
    public partial class searchingbyid : Form
    {
        public searchingbyid()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            Search_data obj = new Search_data();
            string[] Data_array = obj.searchbyid(searchidtxt.Text, "studentrecord.txt").Split('\n');
            for(int i=0;i<Data_array.Length;i++)
            {
                listView1.Items.Add(Data_array[i]);
            }
            
        }
    }
}
