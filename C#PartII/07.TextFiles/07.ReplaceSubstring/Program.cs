using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _07.ReplaceSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("SomeText.txt");
            StreamWriter writer = new StreamWriter("ModifiedText.txt");
            string readFileLine;
            string modifiedLine;
            using (reader)
            {
                using (writer)
                {
                    readFileLine = reader.ReadLine();
                    while (readFileLine != null)
                    {
                        modifiedLine = readFileLine.Replace("start", "finish");
                        writer.WriteLine(modifiedLine);
                        readFileLine = reader.ReadLine();
                    }
                }
            }
        }
    }
}
