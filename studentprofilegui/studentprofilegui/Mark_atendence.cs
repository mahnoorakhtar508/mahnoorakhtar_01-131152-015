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
    public partial class Mark_atendence : Form
    {
        Boolean flag = false, file_creation = false;
        string[] students_sheet = null;
        int Index = 1;
        public Mark_atendence()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backtomenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstwindow main = new firstwindow();
            main.Show();

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

            if (flag == false)
            {
                Search_data obj = new Search_data();
                string Student_att_data;
                Student_att_data = obj.searchsemester(semestersearchtxt.Text, "studentrecord.txt");
                students_sheet = Student_att_data.Split('\n');
                searchbtn.Text = "Next";
                flag = true;
                semestersearchtxt.Text = "";
                MessageBox.Show(Student_att_data);
                name_student.Text = students_sheet[Index];
                presentradiobtn.Enabled = true;
                absentradiobtn.Enabled = true;
            }
            else
            {

                using (StreamWriter obj = new StreamWriter("Attendence.txt", file_creation))
                {
                    file_creation = true;
                    if (presentradiobtn.Checked == true)
                    {
                        obj.WriteLine(students_sheet[Index] + "  Present");
                    }
                    if (absentradiobtn.Checked == true)
                    {
                        obj.WriteLine(students_sheet[Index] + "  Absent");
                    }
                }
                if (Index + 6 < students_sheet.Length)
                {
                    Index += 6;
                    name_student.Text = students_sheet[Index];
                    presentradiobtn.Checked = false;
                    absentradiobtn.Checked = false;
                }
                else
                {
                    presentradiobtn.Enabled = false;
                    absentradiobtn.Enabled = false;
                    flag = false;
                    MessageBox.Show("attendence has been taken");
                }


            }


        }
    }
}