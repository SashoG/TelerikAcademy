using System;


class Integer3Bit
{
    static void Main()
    {
        int test = 255;
        Console.WriteLine("Binary test number is:" + Convert.ToString(test,2).PadLeft(16,'0'));
        int mask = 1 << 3;
        //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0'));
        int conc = test & mask;
        //Console.WriteLine(Convert.ToString(conc, 2).PadLeft(16, '0'));
        int result = conc >> 3;
        Console.WriteLine("3rd bit is:" + result);

    }
}
