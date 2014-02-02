using System;

class BiggestOutOf5
{
    static void Main()
    {
        Console.Write("Enter variable 1:");
        string str1 = Console.ReadLine();
        double var1 = double.Parse(str1);
        Console.Write("Enter variable 2:");
        string str2 = Console.ReadLine();
        double var2 = double.Parse(str2);
        Console.Write("Enter variable 3:");
        string str3 = Console.ReadLine();
        double var3 = double.Parse(str3);
        Console.Write("Enter variable 4:");
        string str4 = Console.ReadLine();
        double var4 = double.Parse(str4);
        Console.Write("Enter variable 5:");
        string str5 = Console.ReadLine();
        double var5 = double.Parse(str5);
        double max = double.MinValue;
        double[] vars = new double[] { var1, var2, var3, var4, var5 };
        foreach (var i in vars)
        {
            if (i >= max)
            {
                max = i;
            }
        }
        Console.WriteLine("Biggest number is:" + max);
    }
}
