using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _12.RemoveWords
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                StreamReader readerText = new StreamReader("SomeText.txt");
                StreamReader readerWords = new StreamReader("WordsToRemove.txt");
                StreamWriter writer = new StreamWriter("CleanedText.txt");
                string line = readerText.ReadLine();
                List<string> word = new List<string>();
                string currentWord;
                using (readerWords)
                {
                    currentWord = readerWords.ReadLine();
                    while (currentWord != null)
                    {
                        word.Add(currentWord);
                        currentWord = readerWords.ReadLine();
                    }

                }
                using (readerText)
                {
                    using (writer)
                    {
                        while (line != null)
                        {
                            for (int i = 0; i < word.Count; i++)
                            {
                                line = line.Replace(" " + word[i], "");
                            }
                            writer.WriteLine(line);
                            line = readerText.ReadLine();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}:{1}", ex.GetType().Name, ex.Message);
            }
        }
    }
}
