using System;


class NNumbers
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string str1 = Console.ReadLine();
        int N = int.Parse(str1);
        int Sum = 0;
        for (int i = 1; i <= N; i++)
        {
        Console.Write("Enter number {0}: ", i);
        string str2 = Console.ReadLine();
        int Number = int.Parse(str2);
        Sum += Number; 
        }
        Console.WriteLine(Sum);
    }
}
