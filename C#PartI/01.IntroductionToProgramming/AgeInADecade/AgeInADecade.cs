using System;

class AgeInADecade
{
    static void Main()
    {
        Console.Write("Enter your current age in years:");
        int age = int.Parse(Console.ReadLine());
        age = age + 10;
        Console.WriteLine("Your age in 10 years will be: " + age);
    }
}

