using System;

class SumOfIntegerSequnce
{
    static void Main()
    {
        //  You are given a sequence of positive integer values written into a string, separated by spaces.
        // Write a function that reads these values from given string and calculates their sum.
        // Example: string = "43 68 9 23 318" -> result = 461

        Console.WriteLine("Please write the integer sequence separated by single space: ");
        Console.Write("-> ");
        string sequence = Console.ReadLine();
        long sum = 0;
        string[] sequenceArray = sequence.Split(' ');
        foreach (var element in sequenceArray)
        {
            sum += int.Parse(element);
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}