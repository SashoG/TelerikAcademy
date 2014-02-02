using System;

class exchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("variable a = " + a + "\n" + "variable b = " + b);
        int exch;
        exch = a;
        a = b;
        b = exch;
        Console.WriteLine("After exchange of values");
        Console.WriteLine("variable a = " + a + "\n" + "variable b = " + b);
    }
}
