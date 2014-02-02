using System;


class BitChanger
{
    static void Main()
    {
        Console.Write("Enter integer n:");
        string str1 = Console.ReadLine();
        int integer = int.Parse(str1);
        Console.WriteLine(Convert.ToString(integer,2).PadLeft(16,'0'));
        Console.Write("Enter position p:");
        string str2 = Console.ReadLine();
        int pos = int.Parse(str2);
        Console.Write("Enter value v (0 or 1):");
        string str3 = Console.ReadLine();
        int val = int.Parse(str3);
        if (val == 1)
        {
            int mask = 1 << pos;
            int result = integer | mask;
            Console.WriteLine("Result is:" + Convert.ToString(result, 2).PadLeft(16, '0'));
        }
        else
        {
            int mask = ~(1 << pos);
            int result = integer & mask;
            Console.WriteLine("Result is:" + Convert.ToString(result, 2).PadLeft(16, '0'));
        }

    }
}


