using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06.SortStringList
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("Strings.txt");
            StreamWriter writer = new StreamWriter("SortedStrings.txt");
            List<string> stringList = new List<string>();

            using (reader)
            {
                string lineContent = reader.ReadLine();
                while (lineContent != null)
                {
                    stringList.Add(lineContent);
                    lineContent = reader.ReadLine();
                }
            }
            stringList.Sort();
            using (writer)
            {
                for (int i = 0; i < stringList.Count; i++)
                {
                    writer.WriteLine(stringList[i]);
                }
            }
            
            

        }
    }
}
