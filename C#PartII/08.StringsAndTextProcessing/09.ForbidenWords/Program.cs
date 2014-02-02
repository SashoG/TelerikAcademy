using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ForbidenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Text:");
            string str = Console.ReadLine();
            Console.Write("Enter Forbidden Words:");
            string[] fWords = Console.ReadLine().Split(',');
            for (int i = 0; i < fWords.Length; i++)
			{
                string replacementString = new String('*', fWords[i].Trim().Length);
                str = str.Replace(fWords[i].Trim(),replacementString);
			}
            Console.WriteLine(str);
        }
    }
}
