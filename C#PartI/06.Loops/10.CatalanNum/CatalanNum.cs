using System;

class CatalanNum
{
    static void Main()
    {
        Console.Write("Enter N>=0:");
        string str1 = Console.ReadLine();
        int N = int.Parse(str1);
        double Catalan = 1;
        if (N>=0)
        {
            for (int i = 1; i <=2*N; i++)
            {
                Catalan *= i;
                if (i <= N)
                {
                    Catalan /= ((i+1)*i);
                }

            }
            Console.WriteLine("Catalan number {0} is {1:0.0000}", N, Catalan);
        }
        else
        {
            Console.WriteLine("Invalid number N");
        }
    }
}
