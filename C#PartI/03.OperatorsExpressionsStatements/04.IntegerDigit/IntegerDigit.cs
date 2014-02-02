using System;


class IntegerDigit
{
    static void Main()
    {
        int testNumber = 1732;
        int div1000 = testNumber % 1000;
        int thirdDigit = div1000 / 100;
        Console.WriteLine((thirdDigit==7) ? "true" : "false");
    }
}

