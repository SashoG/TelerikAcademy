using System;



class Div7and5
{
    static void Main()
    {
        int a = 35;
        bool b = ((a % 7 == 0) && (a % 5 == 0));
        Console.WriteLine(a + " is devidebale by 5 and 7: " + b);
    }
}

