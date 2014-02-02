using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter integer 1: ");
        string str1 = Console.ReadLine();
        int Int1 = int.Parse(str1);
        Console.Write("Enter integer 2: ");
        string str2 = Console.ReadLine();
        int Int2 = int.Parse(str2);
        Console.Write("Enter integer 3: ");
        string str3 = Console.ReadLine();
        int Int3 = int.Parse(str3);
        Console.WriteLine("{0} + {1} + {2} = {3}", Int1, Int2, Int3, Int1 + Int2 + Int3);
    }
}

