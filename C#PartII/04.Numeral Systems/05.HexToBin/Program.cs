using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HexToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Hexadecimal Number:");
            string inputNum = Console.ReadLine();
            for (int i = 0; i < inputNum.Length; i++)
            {
                if (inputNum[i] >= 'A')
                {
                    switch (inputNum[i] - 'A' + 10)
                    {
                        case 10: Console.Write("1010"); ;
                            break;
                        case 11: Console.Write("1011");
                            break;
                        case 12: Console.Write("1100");
                            break;
                        case 13: Console.Write("1101");
                            break;
                        case 14: Console.Write("1110");
                            break;
                        case 15: Console.Write("1111");
                            break;
                    }
                }
                else
                {
                    switch (inputNum[i] - '0')
                    {
                        case 0: Console.Write("0000");
                            break;
                        case 1: Console.Write("0001");
                            break;
                        case 2: Console.Write("0010");
                            break;
                        case 3: Console.Write("0011");
                            break;
                        case 4: Console.Write("0100");
                            break;
                        case 5: Console.Write("0101");
                            break;
                        case 6: Console.Write("0110");
                            break;
                        case 7: Console.Write("0111");
                            break;
                        case 8: Console.Write("1000");
                            break;
                        case 9: Console.Write("1001");
                            break;

                    }
                }
            }
            Console.WriteLine();
        }
    }
}
