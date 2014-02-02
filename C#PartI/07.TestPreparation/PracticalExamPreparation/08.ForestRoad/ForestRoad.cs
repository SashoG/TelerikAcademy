using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ForestRoad
{
    class ForestRoad
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int p = N-2;
            for (int i = 0; i < (2*N-1); i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((i == j && i < N) | (i >= N && j == p))
                    {
                        Console.Write("*");
                        if (i >= N && j == p)
                        {
                            p--;
                        }
                    }
                    else
                    {
                        Console.Write(".");
                    }
   
                }
                Console.WriteLine();
            }
        }
    }
}
