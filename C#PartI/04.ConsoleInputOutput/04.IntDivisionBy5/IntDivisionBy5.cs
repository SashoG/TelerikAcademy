using System;

class IntDivisionBy5
{
    static void Main()
    {
        Console.Write("Enter integer 1: ");
        string str1 = Console.ReadLine();
        int Int1 = int.Parse(str1);
        Console.Write("Enter integer 2: ");
        string str2 = Console.ReadLine();
        int Int2 = int.Parse(str2);
        int counter = 0;
        if (Int1<=Int2)
        {
            for (int i = Int1; i <= Int2; i++)
            {
                if (i % 5 == 0)
                {
                    counter += 1;
                }
            }
            Console.WriteLine("The numbers between {0} and {1} that are divided by 5 without a reminder is {2}", Int1, Int2,counter);
        }
        else
        {
            for (int i = Int2; i <= Int1; i++)
            {
                if (i % 5 == 0)
                {
                    counter += 1;
                }
            }
            Console.WriteLine("The numbers between {0} and {1} that are divided by 5 without a reminder is {2}", Int2, Int1, counter);
        }

    }
}
