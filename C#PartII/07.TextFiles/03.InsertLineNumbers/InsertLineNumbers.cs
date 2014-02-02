using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.InsertLineNumbers
{
    class InsertLineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("SomeTextFile.txt");
            StreamWriter writer = new StreamWriter("FileWithLineNumbers.txt");
            using (writer)
            {
                using (reader)
                {
                    string lineContent = reader.ReadLine();
                    int lineNumber = 0;
                    while (true)
                    {
                        lineNumber++;
                        lineContent = reader.ReadLine();
                        if (lineContent == null)
                        {
                            break;
                        }
                        writer.WriteLine("Line {0}: {1}", lineNumber, lineContent);

                    }
                }
            }



        }
    }
}
