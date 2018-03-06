using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class student
    {
        string name, id, department;
        int semester;
        double cgpa;
        string filepath;
        public void setdata(string ide,string namee,int semesterr,double cgpaa)
        {
            id = ide;
            name = namee;
            semester = semesterr;
            cgpa = cgpaa;
        }
        public void adddata(string filepath)
        {
            StreamWriter write = new StreamWriter(filepath);
            write.WriteLine();
        }
    }
}
