using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HexToDec
{
    class Program
    {
        static int GetNumber(string s, int i)
        {
            if (s[i] >= 'A') return s[i] - 'A' + 10;
            else return s[i] - '0';
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter Hexadecimal Number:");
            string inputNum = Console.ReadLine();
            decimal decResult = new decimal();
            for (int i = 0; i < inputNum.Length; i++)
            {
                
                decResult += (decimal)(GetNumber(inputNum,i)*Math.Pow(16, inputNum.Length - i - 1));
            }
            Console.WriteLine(decResult);

        }
    }
}
