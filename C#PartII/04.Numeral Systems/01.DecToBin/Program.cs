using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DecToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Decimal Number:");
            int inputNum = int.Parse(Console.ReadLine());
            int[] Bin = new int[32];
            for (int i = 31; i >= 0; i--)
            {
                if (inputNum > 0)
                {
                    Bin[i] = inputNum % 2;
                    inputNum /= 2;
                    if (inputNum==0)
                    {
                        break;
                    }
                }
                if (inputNum < 0)
                {
                    inputNum = (int)(Math.Pow(2, 31) + inputNum);
                    Bin[0] = 1;
                    i = 32;
                }
            }
           
            foreach (var digit in Bin)
	        {
		         Console.Write(digit);
	        }
            Console.WriteLine();
        }
    }
}
