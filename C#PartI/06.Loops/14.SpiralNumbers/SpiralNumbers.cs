using System;

class SpiralNumbers
{
    static void Main()
    {
        Console.Write("Enter N<20:");
        string str1 = Console.ReadLine();
        int N = int.Parse(str1);
        int[,] matrix = new int[N, N];
        int counter = 1;
        if (N < 20)
        {
            for (int i = N - 1, j = 0; i >= 0; i--, j++)
            {
                for (int k = j; k < i; k++)
                {
                    matrix[j, k] = counter;
                    counter++;
                }
                for (int k = j; k < i; k++)
                {
                    matrix[k, i] = counter;
                    counter++;
                }
                for (int k = i; k > j; k--)
                {
                    matrix[i, k] = counter;
                    counter++;
                }

                for (int k = i; k > j; k--)
                {
                    matrix[k, j] = counter;
                    counter++;
                }
            }
            if (N % 2 != 0)
            {
                matrix[N / 2, N / 2] = counter;
            }
            for (int l = 0; l < N; l++)
            {
                for (int m = 0; m < N; m++)
                {
                    Console.Write("{0,4}", matrix[l, m]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("You have entered an invalid number");
        }
    }
}
