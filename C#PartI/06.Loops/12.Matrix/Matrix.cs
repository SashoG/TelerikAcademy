using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter N<20:");
        string str1 = Console.ReadLine();
        int N = int.Parse(str1);
        if (N < 20)
        {
            for (int i = 1; i <= N; i++)
            {
                int a = i;
                for (int j = 1; j <= N; j++)
                {
                    Console.Write("{0} ",a);
                    a++;
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
