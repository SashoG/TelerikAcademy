using System;

class Fibonacci
{
    static void Main(string[] args)
    {
        Console.Write("Enter integer number N:");
        string str1 = Console.ReadLine();
        int N = int.Parse(str1);
        decimal FibonacciNext1 = 0;
        decimal FibonacciNext2 = 1;
        decimal inter = 0;
        Console.WriteLine(FibonacciNext1);
        Console.WriteLine(FibonacciNext2);
        for (int i = 1; i <= N-2; i++)
        {
            inter = FibonacciNext2;
            FibonacciNext2 += FibonacciNext1;
            FibonacciNext1 = inter;
            Console.WriteLine(FibonacciNext2);
        }
    }
}
