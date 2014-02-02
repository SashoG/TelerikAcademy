using System;


class Program
{
    static void Main()
    {
        int? NullInteger = null;
        double? NullDouble = null;
        Console.WriteLine("NullInteger: " + NullInteger);
        Console.WriteLine("NullDouble: " + NullDouble);
        Console.WriteLine(NullInteger + 1);
        Console.WriteLine(NullDouble + 1 );
        Console.WriteLine(NullInteger + null);
        Console.WriteLine(NullDouble + null);
    }
}
