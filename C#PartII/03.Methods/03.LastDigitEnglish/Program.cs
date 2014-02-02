using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastDigitEnglish
{
    class Program
    {
        static int LastDigit(int Number)
        {
            return Number % 10;
        }
        static void EnglishName(int digit)
        {
            string[] digitNames = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine("Last digit is: {0}",digitNames[digit]);
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int Number = int.Parse(Console.ReadLine());
            EnglishName(LastDigit(Number));
        }
    }
}
