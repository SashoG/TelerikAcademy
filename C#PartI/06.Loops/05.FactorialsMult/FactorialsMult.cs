using System;

class FactorialsMult
{
    static void Main()
    {
        Console.Write("Enter integer number N:");
        string str1 = Console.ReadLine();
        double N = double.Parse(str1);
        Console.Write("Enter integer number K>N:");
        string str2 = Console.ReadLine();
        double K = double.Parse(str2);
        double Dif = K - N;
        double p = 1;
        while (K >= 1)
        {
            if (N>=1 & Dif>=1)
            {
                p *= ((N * K) / Dif);
                N--;
                K--;
                Dif--;
            }
            else if (Dif<1)
            {
                if (N>=1)
                {
                    p *= (N * K);
                    K--;
                    N--; 
                }
                else
                {
                    p *= K;
                    K--;
                }
            }
            
        }      
        Console.WriteLine("Product N!*K!/(K-N) is: {0}", p);
    }
}
