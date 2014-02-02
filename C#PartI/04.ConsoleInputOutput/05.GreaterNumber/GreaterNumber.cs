using System;


class GreaterNumber
{
    static void Main()
    {
        Console.Write("Enter number 1: ");
        string str1 = Console.ReadLine();
        double Num1 = double.Parse(str1);
        Console.Write("Enter number 2 different from 1: ");
        string str2 = Console.ReadLine();
        double Num2 = double.Parse(str2);
        Console.Write("The greater number is: ");
        Console.WriteLine(Num1>Num2 ? Num1: Num2);
    }
}
