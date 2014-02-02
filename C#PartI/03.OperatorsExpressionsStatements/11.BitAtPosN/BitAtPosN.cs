using System;


class BitAtPosN
{
    static void Main()
    {
        Console.Write("Enter integer:");
        string str1 = Console.ReadLine();
        int integer = int.Parse(str1);
        //Console.WriteLine(Convert.ToString(integer,2).PadLeft(16,'0'));
        Console.Write("Enter position:");
        string str2 = Console.ReadLine();
        int pos = int.Parse(str2);
        int mask = 1 << pos;
        //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0'));
        int maskAndInteger = integer & mask;
        int bit = maskAndInteger >> pos;
        Console.Write("Value of bit at position " + pos);
        Console.WriteLine(" is: " + bit);


    }
}

