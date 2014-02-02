using System;


class comparisonFP
{
    static void Main()
    {
        float a = 5.3f;
        float b = 8f;
        float d = a - b;
        Console.WriteLine("First number is:" + a);
        Console.WriteLine("Second number is:" + b);
        Console.WriteLine("Difference is:" + d);
        bool comparison = ( Math.Abs(d) < 0.000001);
        Console.WriteLine("Absolute value of the difference is below 0.000001:" + comparison);
    }
}

