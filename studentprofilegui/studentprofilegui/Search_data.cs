using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentprofilegui
{
    class Search_data
    {
        public string searchbyid(string id, string fname)
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

                        line += "\n" + file.ReadLine();

                    }
                    break;

                }


            }

            file.Close();
            return line;

        }
        public string searchbyname(string name, string fname)
        {

            string line;
            string prev = null;
            string retrieve_data=null;
            using (StreamReader read = new StreamReader(fname))
            {
                while ((line = read.ReadLine()) != null)
                {

                    retrieve_data = prev + "\n" + line;
                    prev = line;
                    if (name == line)
                    {

                        for (int i = 0; i < 4; i++)
                        {

                            retrieve_data += "\n" + read.ReadLine();
                        }
                        break;

                    }
                }
                

                return retrieve_data;
                
            }
        }
        public string searchsemester(string semester, string fname)
        {

            string line;
            string old = null, old1 = null;
            string prev = null, retrieve_data=null, Returned_data=null;
            using (StreamReader read = new StreamReader(fname))
            {
                while ((line = read.ReadLine()) != null)
                {
                    retrieve_data = old1 + "\n" + old + "\n" + prev + "\n" + line+"\n";

                    if (semester == line)
                    {
                        Returned_data+=retrieve_data;
                        for (int i = 0; i < 2; i++)
                        {

                            Returned_data+= read.ReadLine()+"\n";
                           
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
            return Returned_data;


        }
    }
}
