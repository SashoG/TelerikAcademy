using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Binary Number:");
            string inputNum = Console.ReadLine();
            decimal decResult = new decimal();

            for (int i = 0; i < inputNum.Length; i++)
            {
                if (inputNum[i]=='1')
	            {
                    
                    decResult += (decimal)Math.Pow(2, inputNum.Length-i-1);
	            }
                    
            }
            
            Console.WriteLine(decResult);
        }
    }
}
