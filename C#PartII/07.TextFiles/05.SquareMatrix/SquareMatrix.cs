using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.SquareMatrix
{
    class SquareMatrix
    {
        private static int[,] ReadSquareMatrix(string textFilePath)
        {
            textFilePath = "SquareMatrix.txt";
            StreamReader reader = new StreamReader(textFilePath);
            int[,] numbers;
            int row = 0;
            

            using (reader)
            {
                int matrixSize = int.Parse(reader.ReadLine());
                numbers = new int[matrixSize, matrixSize];
                string str = reader.ReadLine();
                while (str != null)
                {
                    int col = 0;
                    int indexStart = 0;
                    int indexEnd = 0;
                    for (int i = 0; i < str.Length; i++)
                    {
                        indexEnd = str.IndexOf(' ', indexStart) - 1;
                        if (indexEnd < 0)
                        {
                            numbers[row, matrixSize-1] = Convert.ToInt32(str.Substring(indexStart, str.Length - indexStart));
                            break;
                        }
                        else
                        {
                            numbers[row, col] = Convert.ToInt32(str.Substring(indexStart, indexEnd - indexStart + 1));
                            indexStart = indexEnd + 2;
                            col++;
                        }
                        
                    }
                    row++;
                    str = reader.ReadLine();
                }
            }
            return numbers;
        }
        private static int MaxSumPlatform(int[,] matrix)
        {
            int bestSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            return bestSum;
        }

        static void Main(string[] args)
        {
           int[,] Matrix = ReadSquareMatrix("SquareMatrix.txt");
           int sum = MaxSumPlatform(Matrix);
           StreamWriter writer = new StreamWriter("output.txt");
           using (writer)
           {
               writer.Write(sum);
           }
           
        }
    }
}
