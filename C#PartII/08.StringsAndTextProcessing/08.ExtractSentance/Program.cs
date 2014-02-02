using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExtractSentance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Test: ");
            string str = Console.ReadLine();
            string[] Sentences1 = str.Split('.');
            str = str.ToLower();
            string[] Sentences =str.Split('.');
            Console.Write("Enter word: ");
            string word = Console.ReadLine();
            word = word.ToLower();

            for (int i = 0; i < Sentences.Length; i++)
            {
                if (Sentences[i].Trim().IndexOf(" " + word, 0) >= 0 || Sentences[i].Trim().IndexOf(word+ " ", 0) >= 0)
                {
                    Console.WriteLine(Sentences1[i].Trim() + ".");
                }
            }
           
        }
    }
}
