using System;


class BiggestOutOf3
{
    static void Main()
    {
        Console.Write("Enter integer number 1:");
        string str1 = Console.ReadLine();
        int int1 = int.Parse(str1);
        Console.Write("Enter integer number 2:");
        string str2 = Console.ReadLine();
        int int2 = int.Parse(str2);
        Console.Write("Enter integer number 3:");
        string str3 = Console.ReadLine();
        int int3 = int.Parse(str3);
        if (int1==int2|int1==int3|int2==int3)
        {
            Console.WriteLine("Please enter different numbers");
        }
        else
        {
            if (int1 > int2)
            {
                if (int2 > int3)
                {
                    Console.WriteLine("Biggest number is {0}", int1);
                }
                if (int3 > int1)
                {
                    Console.WriteLine("Biggest number is {0}", int3);
                }
            }
            else
            {
                if (int1 > int3)
                {
                    Console.WriteLine("Biggest number is {0}", int2);
                }
                if (int2 < int3)
                {
                    Console.WriteLine("Biggest number is {0}", int3);
                }
            }
            if (int3 > int2)
            {
                if (int1 > int3)
                {
                    Console.WriteLine("Biggest number is {0}", int1);
                }

            }
            else
            {
                if (int3 > int1)
                {
                    Console.WriteLine("Biggest number is {0}", int2);
                }
            }
        }       
    }
}
