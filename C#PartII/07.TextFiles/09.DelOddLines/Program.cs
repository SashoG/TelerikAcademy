using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _09.DelOddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("SomeText.txt");
            StreamWriter writer = new StreamWriter("ModifiedText.txt");
            int lineCounter = 1;
            using (reader)
            {
                using (writer)
                {
                    string lineContent = reader.ReadLine();
                    while (lineContent != null)
                    {
                        if (lineCounter % 2 == 0)
                        {
                            writer.WriteLine(lineContent);
                        }
                        else
                        {
                            writer.WriteLine(" ");
                        }
                        lineCounter++;
                        lineContent = reader.ReadLine();

                    }
                }
            }
            File.Delete("SomeText.txt");
            File.Copy("ModifiedText.txt", "SomeText.txt");
            File.Delete("ModifiedText.txt");
        }
    }
}
