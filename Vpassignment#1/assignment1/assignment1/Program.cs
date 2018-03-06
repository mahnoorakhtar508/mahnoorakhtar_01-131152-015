using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class Program
    {
     
        static void Main(string[] args)
        {
            string id = null;
            string name = null;
            string uni = null;
            string department=null;
            float cgpa;
            string semester = null;
            string attendence = null;
            studentprofile profile = new studentprofile();

            char flag='y';
            while( flag=='y')
            {
                Console.WriteLine("please press \n1:To create student profile \n2:Search student \n3:Delete student " +
               "\n4:Mark attendence \n5:View attendence");
                int choice;
                choice = Convert.ToInt32(Console.ReadLine());
                string filename = "studentrecord.txt";
                if (choice == 1)
                {
                    profile.add(filename);
                  
                }
                else if (choice == 2)
                {
                    char search = 'y';
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(" you have entered in Search zone So please enter \n1:to search by id \n2:to search by name \n3:to search by semester \n   please press only integar value i-e whole number");
                        int option = 0;
                        option = Convert.ToInt32(Console.ReadLine());
                        if (option == 1)
                        {
                            Console.Write("Input your search text: ");
                            id = Console.ReadLine();
                            profile.searchbyid(id,filename);

                        }
                        else if (option == 2)
                        {
                            Console.Write("Input your search text: ");
                            name = Console.ReadLine();
                            profile.searchbyname(name,filename);

                        }
                        else if (option == 3)
                        {

                            Console.WriteLine("please eneter the search content");
                            semester = Console.ReadLine();
                            profile.searchsemester(semester,filename);
                        }


                        Console.WriteLine("please press y if you want to search again by slecting specific option \n and if not so press any other option");
                        search = Convert.ToChar(Console.ReadLine());
                        Console.Clear();
                    } while (search == 'y');
            

                }
                else if (choice == 3)
                {
                    Console.WriteLine("please write id to del record");
                    id = Console.ReadLine();
                    profile.delrecord(id);
                   
                }
                else if (choice == 4)
                {
                    Console.WriteLine("enter the semester num as 'first' ,'second' etc");
                    semester = Console.ReadLine();
                    profile.takeattendence(semester);
                }
                else if (choice == 5)
                {


                }
                else
                {

                    Console.WriteLine("you have pressed an invalid option");

                }
                Console.WriteLine("enter 'y'to see main menu if not press any key.");
                flag = Convert.ToChar(Console.ReadLine());
                Console.Clear();
            }
            
            Console.WriteLine("thanku");
         
            Console.ReadKey();
        }
    }
}
