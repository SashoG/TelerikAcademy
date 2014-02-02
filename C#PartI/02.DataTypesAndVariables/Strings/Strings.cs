using System;


class Strings
{
    static void Main()
    {
        string var1 = "Hello";
        string var2 = "World";
        object conc;
        conc = var1 + " " + var2;
        Console.WriteLine(conc);
        string var3 = (string)conc;
        Console.WriteLine(var3);
    }
}
