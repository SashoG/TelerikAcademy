using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseDigits
{
    class Program
    {

        static int CountDigits(decimal inputNumber)
        {
            int digitCount = 0;
            do
            {
                inputNumber/=10;
                digitCount++;
            } while (inputNumber>=1);
            return digitCount;
        }

        static decimal ReverseDigits(decimal inputNumber)
        {
            decimal reversedNumber = 0;
            int digCount = CountDigits(inputNumber);
            for (int i = 0; i < digCount; i++)
            {
                reversedNumber += (inputNumber % 10) * Convert.ToDecimal(Math.Pow(10, digCount-i-1));
                inputNumber /= 10;
                inputNumber = decimal.Truncate(inputNumber);
            }
            return reversedNumber;
        }
        
        
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            decimal inputNumber = decimal.Parse(Console.ReadLine());
            if (inputNumber<0)
            {
                inputNumber = Math.Abs(inputNumber);
                Console.WriteLine("Reversed number is: {0}", ReverseDigits(inputNumber)*(-1));
            }
            else
            {
                Console.WriteLine("Reversed number is: {0}", ReverseDigits(inputNumber));
            }
           
            
            
        }
    }
}
