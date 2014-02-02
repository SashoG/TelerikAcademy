using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DecToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Decimal Number:");
            int inputNum = int.Parse(Console.ReadLine());
            List<char> Hex = new List<char>();
            do
            {
                switch (inputNum % 16)
                {
                    case 1: Hex.Add('1');
                        break;
                    case 2: Hex.Add('2');
                        break;
                    case 3: Hex.Add('3');
                        break;
                    case 4: Hex.Add('4');
                        break;
                    case 5: Hex.Add('5');
                        break;
                    case 6: Hex.Add('6');
                        break;
                    case 7: Hex.Add('7');
                        break;
                    case 8: Hex.Add('8');
                        break;
                    case 9: Hex.Add('9');
                        break;
                    case 10: Hex.Add('A');
                        break;
                    case 11: Hex.Add('B');
                        break;
                    case 12: Hex.Add('C');
                        break;
                    case 13: Hex.Add('D');
                        break;
                    case 14: Hex.Add('E');
                        break;
                    case 15: Hex.Add('F');
                        break;
                }
                inputNum /= 16;
            } while (inputNum != 0);
            Hex.Reverse();
            foreach (char item in Hex)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
