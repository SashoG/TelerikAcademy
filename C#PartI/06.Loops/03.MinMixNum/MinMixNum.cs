using System;

class MinMixNum
{
    static void Main()
    {
        Console.Write("Enter number of integers N:");
        string str1 = Console.ReadLine();
        int Num = new int();
        bool err = int.TryParse(str1, out Num);
        if (err)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 1; i < Num; i++)
            {
                Console.Write("Enter an integer number {0}:", i);
                string str2 = Console.ReadLine();
                int N = new int();
                bool err1 = int.TryParse(str2, out N);
                if (err1)
                {
                    if (N <= min)
                    {
                        min = N;
                    }
                    if (N >= max)
                    {
                        max = N;
                    }
                }
                else
                {
                    Console.WriteLine("not an integer");
                    return;
                }                
            }
            Console.WriteLine("Maximum number entered: {0}", max);
            Console.WriteLine("Minimum number enetered: {0}", min);  
        }
        else
        {
            Console.WriteLine("not an integer");
        }
       
    }
}