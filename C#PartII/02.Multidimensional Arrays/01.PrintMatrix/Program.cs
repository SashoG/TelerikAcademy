using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter matrix dimension: ");
            int Dimension = int.Parse(Console.ReadLine());
            int[,] matrix = new int[Dimension, Dimension];
            matrix = ExampleA(matrix);
            PrintMatrix(matrix);
            Console.WriteLine();
            matrix = ExampleB(matrix);
            PrintMatrix(matrix);
            Console.WriteLine();
            matrix = ExampleC(matrix);
            PrintMatrix(matrix);
            Console.WriteLine();
            matrix = ExampleD(matrix);
            PrintMatrix(matrix);
        }

        private static int[,] ExampleA(int[,] matrix)
        {
            int index = new int();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = ++index;
                }
            }
            return matrix;
        }
        private static int[,] ExampleB(int[,] matrix2)
        {
            int index = new int();
            for (int col = 0; col < matrix2.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix2.GetLength(1); row++)
                    {
                        matrix2[row, col] = ++index;
                    }
                }
                else
                {
                    for (int row = 3; row >= 0; row--)
                    {
                        matrix2[row, col] = ++index;
                    }
                }
            }
            return matrix2;
        }
        private static int[,] ExampleC(int[,] matrix)
        {
            int index = new int();

            for (int row = 0; row <= matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    matrix[matrix.GetLength(1) - row + col - 1, col] = ++index;
                }
            }

            for (int row = matrix.GetLength(0) - 2; row >= 0; row--)
            {
                for (int col = row; col >= 0; col--)
                {
                    matrix[row - col, matrix.GetLength(1) - col - 1] = ++index;
                }
            }

            return matrix;
        }

        private static int[,] ExampleD(int[,] matrix)
        {
            int index = new int();
            for (int row = matrix.GetLength(0) - 1, col = 0; row >= 0; row--, col++)
            {
                for (int k = col; k < row; k++)
                {
                    matrix[k, col] = ++index;
                }
                for (int k = col; k < row; k++)
                {
                    matrix[row, k] = ++index;
                }
                for (int k = row; k > col; k--)
                {
                    matrix[k, row] = ++index;
                }

                for (int k = row; k > col; k--)
                {
                    matrix[col, k] = ++index;
                }
            }
            if (matrix.GetLength(0) % 2 != 0)
            {
                matrix[matrix.GetLength(0) / 2, matrix.GetLength(0) / 2] = index;
            }

            return matrix;
        }




        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
