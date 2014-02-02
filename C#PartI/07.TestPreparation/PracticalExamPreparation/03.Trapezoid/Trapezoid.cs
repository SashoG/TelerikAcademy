using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i <= N; i++)
            {
                for (int j = 1; j <= 2*N; j++)
                {
                    if ((i==0)&(j <= N))
                    {
                        Console.Write(".");
                    }
                    
                    if ((i==0)&(j > N))
                    {
                        Console.Write("*");
                    }
                    if (((j == N - i+1) || (j == 2 * N))&&(i!=0)&&(i!=N))
                    {
                        Console.Write("*");
                    }
                    if ((!((j == N - i+1) || (j == 2 * N))) && (i != 0)&&(i!=N))
                    {
                        Console.Write(".");
                    }
                    if (i == N)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
