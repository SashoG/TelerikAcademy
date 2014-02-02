using System;

class Fibonacci
{
    static void Main()
    {
        decimal FibonacciNext1 = 0;
        decimal FibonacciNext2 = 1;
        decimal inter = 0;
        Console.WriteLine(FibonacciNext1);
        Console.WriteLine(FibonacciNext2);
        for (int i = 0; i <= 97; i++)
			{
                inter = FibonacciNext1;
                FibonacciNext1 += FibonacciNext2;
                FibonacciNext2 = inter;
                Console.WriteLine(FibonacciNext1);
			}
        
    }
}
