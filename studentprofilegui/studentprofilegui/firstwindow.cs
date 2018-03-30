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
    public partial class firstwindow : Form
    {
        public firstwindow()
        {
            InitializeComponent();
        }

        private void addinginfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_record obj = new add_record();
            obj.Show();
            
        }

        private void firstwindow_Load(object sender, EventArgs e)
        {
            
        }

        private void searchingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchingdata obj = new searchingdata();
            obj.Show();
        }

        private void deleting_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_record del = new delete_record();
            del.Show();
        }

        private void top_cgpabtn_Click(object sender, EventArgs e)
        {

        }

        private void mark_attendencebtn_Click(object sender, EventArgs e)
        {
            Mark_atendence obj = new Mark_atendence();
            this.Hide();
            obj.Show();
        }

        private void view_attendencebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            view_attendence view = new view_attendence();
            view.Show();
        }
    }
}
