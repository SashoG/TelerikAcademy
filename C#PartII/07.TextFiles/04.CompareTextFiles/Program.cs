using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _04.CompareTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader1 = new StreamReader("File1.txt");
            StreamReader reader2 = new StreamReader("File2.txt");
            int equalLines = new int();
            int notEqualLines = new int();
            using (reader1)
            {
                using (reader2)
                {
                    string str1 = reader1.ReadLine();
                    string str2 = reader2.ReadLine();
                    while (str1 != null)
                    {
                        if (str1.Equals(str2))
                        {
                            equalLines++;
                        }
                        else
                        {
                            notEqualLines++;
                        }
                        str1 = reader1.ReadLine();
                        str2 = reader2.ReadLine();
                    }
                }
            }
            Console.WriteLine("Number of equal lines: {0}", equalLines);
            Console.WriteLine("Number of not equal lines: {0}", notEqualLines);

        }
    }
}
