using System;


class BitExchanger2
{
    static void Main()
    {
        Console.Write("Enter integer n:");
        string str1 = Console.ReadLine();
        long integer = long.Parse(str1);
        Console.WriteLine(Convert.ToString(integer, 2).PadLeft(32, '0'));

        Console.Write("Enter starting bit from the left (p):");
        string str2 = Console.ReadLine();
        byte p = byte.Parse(str2);

        Console.Write("Enter number of bits to exchange (k):");
        string str3 = Console.ReadLine();
        byte k = byte.Parse(str3);

        Console.Write("Enter starting bit from the right (q):");
        string str4 = Console.ReadLine();
        byte q = byte.Parse(str4);

        for (byte i = 0; i <= k; i++)
        {
            long mask1 = (1 << (k + i));
            long mask2 = 1 << (q + i);
            long intAndMask1 = integer & mask1;
            long bitPos1st = intAndMask1 >> (p + i);
            long intAndMask2 = integer & mask2;
            long bitPos2nd = intAndMask2 >> (q + i);
            if (bitPos1st != bitPos2nd)
            {
                integer ^= 1 << (p + i);
                integer ^= 1 << (q + i);
            }
        }
        Console.WriteLine(Convert.ToString(integer, 2).PadLeft(32, '0'));

    }
}


