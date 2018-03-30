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
    public partial class add_record : Form
    {
        private string id;
        private string name;
        private float cgpa;
        private string semester;
        private string department;
        private string uni;
        private string filename;
        public add_record()
        {
            InitializeComponent();
            id = null;
            name = null;
            cgpa = 0;
            semester = null;
            department = null;
            uni = null;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void infoaddbutton_Click(object sender, EventArgs e)
        {
            add(filename);
            MessageBox.Show("record added");
            enrollmenttext.Text = String.Empty; //clears up text field after click
            nametext.Text = String.Empty;
            cgpatext.Text = String.Empty;
            semestertext.Text = String.Empty;
            departmenttext.Text = String.Empty;
            unitext.Text = String.Empty;
        }
        public bool checkduplicate(string id)
        {
            string path = @"studentrecord.txt";
            if (System.IO.File.Exists(path))
            {
                using (System.IO.StreamReader read = new StreamReader(path))
                {
                    string line;
                    while ((line = read.ReadLine()) != null)
                    {
                        if (line.Equals(id))
                            return true;
                        else { return false; }
                    }
                }
            }
            else { return false; }
            return false;
           
        }
        public void add(string fname)
        {
            do
            {
                id = enrollmenttext.Text;
                if (checkduplicate(id))
                {
                    MessageBox.Show("write unique id");
                }
                else
                {
                    name = nametext.Text;
                    if (cgpa > 1.0 && cgpa <= 4.0)
                    {
                        cgpa = float.Parse(cgpatext.Text);
                    }
                    semester = semestertext.Text;
                    department = departmenttext.Text;
                    uni = unitext.Text;
                }
            } while (checkduplicate(id));
            using (StreamWriter write = new StreamWriter(@"studentrecord.txt", true)) //creates a file in projects bin
                    {
                        write.WriteLine(enrollmenttext.Text);
                        write.WriteLine(nametext.Text);
                        write.WriteLine(cgpatext.Text);
                        write.WriteLine(semestertext.Text);
                        write.WriteLine(departmenttext.Text);
                        write.WriteLine(unitext.Text);
                    }


          

        }
        public string getname()
        {
            return name;
        }
        public void setname(string namee)
        {
            name = namee;
        }

        private void back_main_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstwindow main = new firstwindow();
            main.Show();
        }
    }
}
