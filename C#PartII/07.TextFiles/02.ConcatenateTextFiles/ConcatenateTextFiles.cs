using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main(string[] args)
        {
            StreamReader reader1 = new StreamReader("File1.txt");
            StreamReader reader2 = new StreamReader("File2.txt");
            StreamWriter writer = new StreamWriter("ConcatenatedFiles.txt");
            using (writer)
            {
                using (reader1)
                {
                    writer.Write(reader1.ReadToEnd());
                }
                using (reader2)
                {
                    writer.Write(reader2.ReadToEnd());
                }
            }
           
        }
    }
}
