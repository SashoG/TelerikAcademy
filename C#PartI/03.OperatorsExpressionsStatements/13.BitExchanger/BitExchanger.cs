using System;


class BitExchanger
{
    static void Main()
    {
        Console.Write("Enter integer n:");
        string str1 = Console.ReadLine();
        long integer = long.Parse(str1);
        Console.WriteLine(Convert.ToString(integer, 2).PadLeft(32, '0'));
       
        long mask1 = 1 << 3;
        long mask2 = 1 << 4;
        long mask3 = 1 << 5;
        long mask4 = 1 << 24;
        long mask5 = 1 << 25;
        long mask6 = 1 << 26;
        
        long intAndMask1 = integer & mask1;
        long bitPos3= intAndMask1 >> 3;
        
        long intAndMask2 = integer & mask2;
        long bitPos4= intAndMask2 >> 4;
       
        long intAndMask3 = integer & mask3;
        long bitPos5= intAndMask3 >> 5;
        
        long intAndMask4 = integer & mask4;
        long bitPos24= intAndMask4 >> 24;
        
        long intAndMask5 = integer & mask5;
        long bitPos25= intAndMask5 >> 25;
       
        long intAndMask6 = integer & mask6;
        long bitPos26= intAndMask6 >> 26;

        if (bitPos3 != bitPos24)
            { 
            integer ^= (1<<3);
            integer ^= (1<<24);
            }
        if (bitPos4 != bitPos25)
            { 
            integer ^= (1<<4);
            integer ^= (1<<25);
            }
        if (bitPos5 != bitPos26)
            { 
            integer ^= (1<<5);
            integer ^= (1<<26);
            }
        Console.WriteLine(Convert.ToString(integer, 2).PadLeft(32, '0'));
       
    }
}


