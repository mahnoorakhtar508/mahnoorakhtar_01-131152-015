using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentprofilegui
{
    class del_data
    {
        public void delrecord(string id)
        {
            StreamWriter write = new StreamWriter("update.txt");
            write.AutoFlush = true;
            using (StreamReader read = new StreamReader("studentrecord.txt"))
            {

                string line;
                while ((line = read.ReadLine()) != null)
                {
                    if (line == id)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            line += "\n" + read.ReadLine();

                        }

                    }
                    else
                    {
                        MessageBox.Show("record deleted");
                        write.WriteLine(line);
                    }

                }
            }

            write.Close();
            File.Delete("studentrecord.txt");
            File.Copy("update.txt", "studentrecord.txt");
            File.Delete("update.txt");


        }
    }
}

