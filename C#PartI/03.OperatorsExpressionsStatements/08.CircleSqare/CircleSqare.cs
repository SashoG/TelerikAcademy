using System;
using System.Threading;
using System.Globalization;

class CircleSqare
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter coordinate X:");
        string str1 = Console.ReadLine();
        double X = double.Parse(str1);
        Console.Write("Enter coordinate Y:");
        string str2 = Console.ReadLine();
        double Y = double.Parse(str2);
        bool incircle=(Math.Sqrt((X-1.1)*(X-1.1)+Y*Y))<=3;
        bool outrectangle = (X>=5||X<=-1||Y>=1||Y<=-1);
        Console.WriteLine(incircle&&outrectangle ? "Pount is in the circle and out of the rectangle" : "Point is somewhere else");
        
    }
}
