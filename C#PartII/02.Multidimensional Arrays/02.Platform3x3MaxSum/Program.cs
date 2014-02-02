using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Platform3x3MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns M:");
            int M = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, M];
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < M; col++)
                {
                    Console.WriteLine("Matrix[{0},{1}] = ", row,col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            int bestSum = int.MinValue;
            int bestRow = new int();
            int bestCol = new int();
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                            + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                            + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            for (int row = bestRow; row < bestRow+3; row++)
            {
                for (int col = bestCol; col < bestCol+3; col++)
                {
                    Console.Write("{0,4}",matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
