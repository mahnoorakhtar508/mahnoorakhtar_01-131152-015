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
    public partial class view_attendence : Form
    {
        
        public view_attendence()
        {
            InitializeComponent();
        }

        private void attendence_display_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void search_Click(object sender, EventArgs e)
        {

           
            using (StreamReader read = new StreamReader("Attendence.txt"))
            {
               
                string line = null;
               
                while ((line = read.ReadLine()) != null)
                {

                   
                    listing.Items.Add(line);



                }
            
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstwindow obj = new firstwindow();
            obj.Show();
        }
    }
}
