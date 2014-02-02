using System;


class BiggerNumber
{
    static void Main()
    {
        Console.Write("Enter integer 1:");
        string str1 = Console.ReadLine();
        int int1 = int.Parse(str1);
        Console.Write("Enter integer 2:");
        string str2 = Console.ReadLine();
        int int2 = int.Parse(str2);
        if (int1>int2)
        {
            int container = new int();
            container = int1;
            int1 = int2;
            int2 = container;
            Console.WriteLine("integer 1 is now: {0}\ninteger 2 is now {1}",int1, int2 );
        }
        else
        {
            Console.WriteLine("integer 1 is now: {0}\ninteger 2 is now {1}", int1, int2);
        }
    }
}
