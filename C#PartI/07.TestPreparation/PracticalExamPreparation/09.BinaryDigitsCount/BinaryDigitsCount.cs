using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.BinaryDigitsCount
{
    class BinaryDigitsCount
    {
        static void Main(string[] args)
        {
            byte B = byte.Parse(Console.ReadLine());
            ushort N = ushort.Parse(Console.ReadLine());
            uint[] Number = new uint[N];
            byte[] ZeroDigitCount = new byte[N];
            byte[] OneDigitCount = new byte[N];
            for (int i = 0; i < N; i++)
			{
                Number[i] = uint.Parse(Console.ReadLine());
			}
            for (int i = 0; i < N; i++)
            {
                byte counter = new byte();
                for (byte j = 31; j >= 0; j--)
			    {
                    uint mask = 1U << j;
                    uint maskAndNumber = mask & Number[i];
                    if (maskAndNumber!=0)
                    {
                        counter = j; break;
                    }
                }
                for (int j = counter; j >= 0; j--)
			    {
			        uint mask = 1U << j;
                    uint maskAndNumber = mask & Number[i];
                    if (maskAndNumber==0)
                    {
                        ZeroDigitCount[i]++; 
                    }
                    else
                    {
                        OneDigitCount[i]++;
                    }
			    }                              
            }
            for (int k = 0; k < N; k++)
            {
                if (B == 0)
                {
                    Console.WriteLine(ZeroDigitCount[k]);
                }
                else
                {
                    Console.WriteLine(OneDigitCount[k]);
                }
            }
        }
    }
}
