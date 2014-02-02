using System;


class StringEscSec
{
    static void Main()
    {
        string WithOutQuoStr = "the \"use\" of quotations causes dificulties";
        Console.WriteLine("Without quoted strings: " + WithOutQuoStr);
        string WithQuoStr = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("With quoted strings: " + WithQuoStr);
    }
}
