using System;

class PrimeCheck
{
    static void Main()
    {
        Console.Write("Enter a number (< 100):");
        string str = Console.ReadLine();
        int number = int.Parse(str);
        bool test1 = (number % 2) != 0;
        bool test2 = (number % 3) != 0;
        bool test3 = (number % 5) != 0;
        bool test4 = (number % 7) != 0;
        bool result = test1 & test2 & test3 & test4;
        Console.WriteLine(result ? "number is prime" : "number is not prime");
    }
}
