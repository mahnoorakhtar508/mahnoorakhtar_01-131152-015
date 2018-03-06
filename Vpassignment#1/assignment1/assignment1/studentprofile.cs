using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class studentprofile
    {
        private string id;
        private string name;
        private float cgpa;
        private string  semester;
        private string department;
        private string uni;
        public studentprofile()
        {
            id = null;
            name = null;
            cgpa = 0;
            semester = null;
            department = null;
            uni = null;
        }
       
        public void add(string fname)
        {


            string choice = "y" ;
            do
            {
                Console.WriteLine("please insert student id");
                id = Console.ReadLine();
                if (checkduplicate(id))
                {
                    Console.WriteLine("Please Enter Unique ID.  ");
                   
                }
                
            } while (checkduplicate(id));
            Console.WriteLine("please insert student name ");
                name = Console.ReadLine();
                Console.WriteLine("please insert student cgpa out of 4.0");

                if (cgpa >= 1.0 || cgpa <= 4.0)
                {
                    cgpa = float.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("you have written an invalid number");
                }
                Console.WriteLine("please insert student semester number as 'first' ,'second' etc");
                semester = Console.ReadLine();
                Console.WriteLine("please enter department name");
                department = Console.ReadLine();
                Console.WriteLine("please enter university name");
                uni = Console.ReadLine();
         

           
            using (StreamWriter write = new StreamWriter(fname, true))
            {
                write.WriteLine(id);
                write.WriteLine(name);
                write.WriteLine(cgpa);
                write.WriteLine(semester);
                write.WriteLine(department);
                write.WriteLine(uni);
              
            }
        }
        public void searchbyid(string id, string fname)
        {

            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(fname);
            while ((line = file.ReadLine()) != null)
            {
                
                if (line == id) //compares each line and state it as matched or not matched
                {
                    for (int i = 0; i < 5; i++)
                    {
                        
                        line += "\n"+file.ReadLine();
                    }
                    Console.WriteLine(line);
                }
                

            }

            file.Close();

        }
        public void searchbyname(string name, string fname)
        {

            string line;
            string prev=null,retrieve_data;
            using (StreamReader read = new StreamReader(fname))
            {
                while ((line = read.ReadLine()) != null)
                {
                    
                    retrieve_data=prev+"\n"+line;
                    prev = line;
                    if (name == line)
                    {
                        
                        for (int i = 0; i < 4; i++)
                        {

                            retrieve_data += "\n"+ read.ReadLine();
                        }

                        Console.WriteLine(retrieve_data);


                    }

                }
            }
        }


        public void searchsemester(string semester, string fname)
        {

            string line;
            string old = null,old1=null;
            string prev = null, retrieve_data;
            using (StreamReader read = new StreamReader(fname))
            {
                while ((line = read.ReadLine()) != null)
                {
                    
                    retrieve_data =old1+"\n"+old+ "\n" + prev + "\n" + line;
                    
                    
                
                    if (semester == line)
                    {
                        for (int i = 0; i < 2; i++)
                        {

                            retrieve_data += "\n" + read.ReadLine();
                        }

                        Console.WriteLine(retrieve_data);


                    }
                    else
                    {

                        old1 = old;
                        old = prev;
                        prev = line;
                    }

                }
            }


        }

        public bool checkduplicate(string id)
        {
            string path = @"studentrecord.txt";
            if (File.Exists(path))
            {
                using (StreamReader read = new StreamReader(path))
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
        public void takeattendence(string semester )
        {
            String attendence = null;
            StreamWriter write = new StreamWriter("attendence.txt",true);
            write.AutoFlush = true;
            using (StreamReader read = new StreamReader("studentrecord.txt"))
            {
                String line ;
                string old1 = null;
                string old =null;
                string prev = null;
                while ((line = read.ReadLine()) != null)
                {
                    if(line==semester)    
                    {
                       
                            Console.WriteLine("Student name \t \t Enrollment");
                            Console.WriteLine(old + "\t \t" + old1);
                            Console.WriteLine("Write  P for Present A for absent");
                             attendence = Console.ReadLine();
                            if (attendence == "P")
                            {
                            Console.WriteLine("present");
                                write.WriteLine(old1 + "\t \t" + old + "\t \t" + attendence);
                            }
                            else if (attendence == "A")
                            {
                            Console.WriteLine("absent");
                            write.WriteLine(old1 + "\t \t" + old + "\t \t" + attendence);
                            }
                        else
                        {

                        }
                    }
                    else
                    {
                        old1 = old;
                        old = prev;
                        prev = line;
                    }
                }   
            }
            write.Dispose();
        }
     public void delrecord(string id)
        {
            StreamWriter write = new StreamWriter("update.txt");
            write.AutoFlush = true;
            using (StreamReader read = new StreamReader("studentrecord.txt"))
            {
                string line;
                while((line=read.ReadLine())!=null)
                {
                    if(line==id)
                    {
                        for(int i=0;i<5;i++)
                        {
                            line += "\n" + read.ReadLine();
                         
                        }
                       
                    }
                    else
                    {
                        Console.WriteLine(line);
                        write.WriteLine(line);
                    }
                   
                }
            }
            write.Dispose();
        }
    }
}

