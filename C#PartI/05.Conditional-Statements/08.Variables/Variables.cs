using System;
using System.Threading;
using System.Globalization;

class Variables
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter type of variable /integer, double or string/:");
        switch (Console.ReadLine())
        {
            case "integer":
                Console.Write("Enter variable:");
                string str1 = Console.ReadLine();
                int int1 = int.Parse(str1);
                Console.WriteLine("You entered + 1:{0}",int1+1);
                break;
            case "int":
                Console.Write("Enter variable:");
                string str2 = Console.ReadLine();
                int int2 = int.Parse(str2);
                Console.WriteLine("You entered + 1: {0}",int2+1);
                break;
            case "double":
                Console.Write("Enter variable:");
                string str3 = Console.ReadLine();
                double d1 = double.Parse(str3);
                Console.WriteLine("You entered + 1: {0:0.000}",d1+1);
                break;
            case "string":
                Console.Write("Enter variable:");
                string str4 = Console.ReadLine();
                Console.WriteLine("You entered + *: {0}", str4 + "*");
                break;
            default:
                Console.WriteLine("You have entered somthing else");
                break;
        }
    }
}
