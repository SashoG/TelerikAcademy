using System;


class FactorialsDiv
{
    static void Main()
    {
        Console.Write("Enter integer number N:");
        string str1 = Console.ReadLine();
        int N = int.Parse(str1);
        Console.Write("Enter integer number K:");
        string str2 = Console.ReadLine();
        int K = int.Parse(str2);
        double p = 1;       
        while (K>=1)
        {
            if (N>=1)
            {
                p *= ((double)N / K);
                N--;
                K--;
            }
            else
            {
                p *= K;
                K--;
            }
        }
        Console.WriteLine("Product N!/K! is: {0}",p);
     
    }
}
