using System;

class SumNX
{
    static void Main()
    {
        Console.Write("Enter integer number N:");
        string str1 = Console.ReadLine();
        int N = int.Parse(str1);
        Console.Write("Enter integer number X:");
        string str2 = Console.ReadLine();
        int X = int.Parse(str2);
        double Sum = 0;
        while (N>=0)
        {
            double Fact = 1;
            for (int i = 1; i <= N; i++)
            {
                Fact *= i; 
            }
            Sum += Fact / Math.Pow(X, N);
            if (N != 0)
            {
                Console.Write("{0}!/{1}^{0} + ", N, X);
            }
            else
            {
                Console.Write("1");
            }
            N--;
        }
        Console.WriteLine("= {0:0.00000}", Sum);
    }
}
