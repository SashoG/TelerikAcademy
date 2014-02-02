using System;

class Numbers1ToN
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        string str1 = Console.ReadLine();
        int Int1 = int.Parse(str1);
        for (int i = 1; i <= Int1; i++)
        {
            Console.WriteLine(i);
        }
    }
}