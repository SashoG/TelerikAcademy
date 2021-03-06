﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
//	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

namespace _20.VariationsKoutOfN
{
    class VariationsKoutOfN
    {
        private static void Variations(int varNum, int j)
        {
            if (varNum == K)
            {
                PrintVariations();
                return;
            }
            else
            {
                for (int i = j; i <= N; i++)
                {
                    numGroup[varNum] = i;
                    Variations(varNum + 1, i + 1);
                }
            }

        }
        private static void PrintVariations()
        {
            for (int i = 0; i < K; i++)
            {
                Console.Write("{0} ", numGroup[i]);
            }
            Console.WriteLine();
        }


        static int N;
        static int K;
        static int[] numGroup;


        static void Main(string[] args)
        {
            Console.Write("Enter number N: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Enter number K: ");
            K = int.Parse(Console.ReadLine());
            numGroup = new int[K];
            Variations(0, 1);

        }
    }
}
