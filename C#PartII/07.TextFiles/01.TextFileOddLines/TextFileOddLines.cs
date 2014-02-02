using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.TextFileOddLines
{
    class TextFileOddLines
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("SomeTextFile.txt");
            using (streamReader)
            {
                int lineNumber = 0;
                string lineContents = streamReader.ReadLine();

                do
                {
                    lineNumber ++;
                    if (lineNumber%2==1)
                    {
                        Console.WriteLine("Line {0} : {1}", lineNumber, lineContents);

                    }
                    lineContents = streamReader.ReadLine();

                } while (lineContents!=null);
            }
        }
    }
}
