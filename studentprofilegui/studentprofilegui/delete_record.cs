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
    public partial class delete_record : Form
    {
        public delete_record()
        {
            InitializeComponent();
        }

        private void back_main_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstwindow main = new firstwindow();
            main.Show();
        }
 

        private void deletebtn_Click(object sender, EventArgs e)
        {
            del_data del = new del_data();
            del.delrecord(delete_recordtxt.Text);
        }
    }
}
