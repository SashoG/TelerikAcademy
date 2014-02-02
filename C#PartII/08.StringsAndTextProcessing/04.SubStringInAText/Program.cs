using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SubStringInAText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("text:");
            string inputText = Console.ReadLine();
            inputText=inputText.ToLower();
            Console.Write("target:");
            string target = Console.ReadLine();
            target = target.ToLower();
            int indexer = 0;
            int counter = 0;
            for (int i = 0; i < inputText.Length; i++)
            {
                indexer = inputText.IndexOf(target,indexer);
                if (indexer>=0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
                indexer++;

            }
            Console.WriteLine(counter);
        }
    }
}
