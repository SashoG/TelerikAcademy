using System;

    class Circle
{
    static void Main()
    {
        Console.Write("Enter radius of a circle: ");
        string str1 = Console.ReadLine();
        double Radius = double.Parse(str1);
        if (Radius >= 0)
        {
            Console.WriteLine("Circle perimeter: {0:0.000}", 2 * Math.PI * Radius);
            Console.WriteLine("Circle area: {0:0.000}", Math.PI * Radius * Radius);
        }
        else
        {
            Console.WriteLine("Not a circle");
        }
    }
}
