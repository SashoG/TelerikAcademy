using System;

class GCD
{
    static void Main()
    {
        Console.Write("Enter integer number 1:");
        string str1 = Console.ReadLine();
        int Num1 = int.Parse(str1);
        Console.Write("Enter integer number 2:");
        string str2 = Console.ReadLine();
        int Num2 = int.Parse(str2);
        Console.Write("GCD of {0} and {1}", Num1, Num2);
        int inter = new int();
        int Reminder = 1;
        if (Num1<=Num2)
        {
            inter = Num1;
            Num1 = Num2;
            Num2 = inter;
        }
        while (Reminder != 0)
        {
                inter = Num2;
                Reminder = Num1 % Num2;
                Num2 = Reminder;
                Num1 = inter;                
        }
        Console.WriteLine(" is: {0}", inter);
    }
}
