using System;


class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter side a:");
        string str1 = Console.ReadLine();
        double a = double.Parse(str1);
        Console.Write("Enter side b:");
        string str2 = Console.ReadLine();
        double b = double.Parse(str2);
        Console.Write("Enter height h:");
        string str3 = Console.ReadLine();
        double h = double.Parse(str3);
        double area = ((a + b) / 2) * h;
        Console.Write("Trapezoid area is:");
        Console.WriteLine(area);
    }
}

