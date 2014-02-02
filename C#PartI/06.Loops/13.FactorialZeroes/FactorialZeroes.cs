using System;

class FactorialZeroes
{
    static void Main()
    {
        Console.Write("Enter integer N:");
        string str1 = Console.ReadLine();
        int N = int.Parse(str1);
        int NumZeroes = 0;
        double product = 10;
        int i = 1;
        while (product>=1)
        {
            NumZeroes += N / (int)Math.Pow(5, i);
            i++;
            product = N/Math.Pow(5, i);
        }
        Console.WriteLine("{0}! has {1} zeroes", N, NumZeroes);
    }
}
