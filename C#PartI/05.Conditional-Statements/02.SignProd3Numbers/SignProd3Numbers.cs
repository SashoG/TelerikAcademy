using System;

class SignProd3Numbers
{
    static void Main()
    {
        Console.Write("Enter real number 1:");
        string str1 = Console.ReadLine();
        double rn1 = double.Parse(str1);
        Console.Write("Enter real number 2:");
        string str2 = Console.ReadLine();
        double rn2 = double.Parse(str2);
        Console.Write("Enter real number 3:");
        string str3 = Console.ReadLine();
        double rn3 = double.Parse(str3);
        if (rn3==0|rn2==0|rn1==0)
        {
            Console.WriteLine("product is zero");
        }
        else if (rn1 < 0 & rn2 < 0 & rn3 < 0)
        {
            Console.WriteLine("product is negative");
        }
        else if (rn1 < 0 & rn2 < 0 & rn3 > 0)
        {
            Console.WriteLine("product is positive");
        }
        else if (rn1 < 0 & rn2 > 0 & rn3 < 0)
        {
            Console.WriteLine("product is positive");
        }
        else if (rn1 > 0 & rn2 < 0 & rn3 < 0)
        {
            Console.WriteLine("product is positive");
        }
        else if (rn1 < 0 & rn2 > 0 & rn3 > 0)
        {
            Console.WriteLine("product is negative");
        }
        else if (rn1 > 0 & rn2 > 0 & rn3 > 0)
        {
            Console.WriteLine("product is positive");
        }
    }
}
