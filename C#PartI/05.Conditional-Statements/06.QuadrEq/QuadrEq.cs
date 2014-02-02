using System;

class QuadrEq
{
    static void Main()
    {
        Console.WriteLine("Quadratic equation of the kind a*x^2 + b*x + c = 0");
        Console.Write("Enter coefficent a:");
        string str1 = Console.ReadLine();
        double a = double.Parse(str1);
        Console.Write("Enter coefficent b:");
        string str2 = Console.ReadLine();
        double b = double.Parse(str2);
        Console.Write("Enter coefficent c:");
        string str3 = Console.ReadLine();
        double c = double.Parse(str3);
        double D = b * b - 4 * a * c;
        if (D > 0)
        {
            Console.WriteLine("Equation has two different roots: {0:0.000} and {1:0.000}", (-b+D)/(2*a), (-b-D)/(2*a));
        }
        if (D < 0)
        {
            Console.WriteLine("Equation has no real roots");
        }
        if (D == 0)
        {
            Console.WriteLine("Equation has two equal roots:{0:0.000}", -b / (2 * a));
        }
    }
}
