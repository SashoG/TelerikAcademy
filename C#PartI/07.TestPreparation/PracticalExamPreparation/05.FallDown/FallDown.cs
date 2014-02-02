using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FallDown
{
    class FallDown
    {
        static void Main(string[] args)
        {
            byte[] N = new byte[8];
            sbyte[] CounterCoulmn = new sbyte[8];
            for (int i = 0; i < 8; i++)
            {
                N[i] = byte.Parse(Console.ReadLine());
            }

            for (int j = 0; j < 8; j++) // column position
            {
                for (int i = 0; i < 8; i++) // number or row
                {
                    int Mask = 1 << j;
                    int NandMask = Mask & N[i];
                    if (NandMask > 0)
                    {
                        CounterCoulmn[j]++;
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                N[i] = 0;
            }
            for (int i = 0; i < 8; i++)
            {
                int k = 0;
                while (CounterCoulmn[i]>0)
                {
                    int Mask = 1 << i;
                    N[k] |= (byte)Mask;
                    k++;
                    CounterCoulmn[i]--;
                }
            }
            for (int i = 7; i >= 0; i--)
            {
                Console.WriteLine(N[i]);
            }
            
        }
    }
}
