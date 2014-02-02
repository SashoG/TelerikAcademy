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
            readFileLine = reader.ReadLine();
            Console.Write("Enter word to look for: ");
            string word = Console.ReadLine();
            word = " " + word + " ";
            Console.Write("Enter replacing word: ");
            string replacingWord = Console.ReadLine();
            replacingWord = " " + replacingWord + " ";
            using (reader)
            {
                using (writer)
                {
                    
                    while (readFileLine != null)
                    {
                        modifiedLine = readFileLine.Replace(word, replacingWord);
                        writer.WriteLine(modifiedLine);
                        readFileLine = reader.ReadLine();
                    }
                }
            }
        }
    }
}
