using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BinToHex
{
    class Program
    {
        static char GetChar(int input)
        {
            if (input >= 10) return (char)('A' + input - 10);
            else return (char)('0' + input);
        }

        static int GetNumber(string s, int i)
        {
            return s[i] - '0';
        }

        static string BinToHex(string input)
        {
            if (input.Length % 4 != 0) return BinToHex(new String('0', 4 - input.Length % 4) + input); // Padleft

            string outString = String.Empty;

            for (int i = input.Length - 1; i >= 0; i -= 4)
            {
                int Bit4 = 0;

                for (int j = 0, power = 1; j < 4; j++, power *= 2)
                    Bit4 += GetNumber(input, i - j) * power;
                outString = GetChar(Bit4) + outString;
            }

            return outString;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter Binary Number:");
            string inputNum = Console.ReadLine();
            Console.WriteLine(BinToHex(inputNum));
        }
    }
}