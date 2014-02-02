using System;

class PointInCircle
{
    static void Main()
    {
        int X = 10;
        int Y = 3;
        int R = 5;
        Console.WriteLine(Math.Sqrt((X * X) + (Y * Y)) <= R ? "point is inside the circle":"point is outside the circle");
    }
}
