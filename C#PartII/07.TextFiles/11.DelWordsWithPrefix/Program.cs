using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _10.ExtractText
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("SomeText.txt");
            StreamWriter writer = new StreamWriter("Modified.txt");
            string lineContent = reader.ReadLine();
            using (reader)
            {
                using (writer)
                {
                    while (lineContent != null)
                    {
                        lineContent = Regex.Replace(lineContent, @"(\b)test((\w)*)(\b)", "");
                        writer.WriteLine(lineContent);
                        lineContent = reader.ReadLine();
                    }
                }
            }
        }
    }
}
