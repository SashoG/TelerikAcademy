using System;


class QuadraticEq
{
    static void Main()
    {
        Console.WriteLine("Enter coeficients of quadratic equation of the type ax^2+bx+c=0");
        Console.Write("a: ");
        string str1 = Console.ReadLine();
        double a = double.Parse(str1);
        Console.Write("b: ");
        string str2 = Console.ReadLine();
        double b = double.Parse(str2);
        Console.Write("c: ");
        string str3 = Console.ReadLine();
        double c = double.Parse(str3);
        double D = (b * b) - 4 * a * c;
        if ( D >= 0)
        {
            Console.WriteLine("Roots are:");
            Console.WriteLine((-b + D)/(2*a));
            Console.WriteLine((-b - D)/(2*a));
        }
        else
        {
            Console.WriteLine("Equation has no real roots");
        }
    }
}
