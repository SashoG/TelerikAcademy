using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that compares two char arrays lexicographically (letter by letter)

class CompareChar
{
    static void Main(string[] args)
    {
        Console.Write("Enter Arrays dimension:");
        int N = int.Parse(Console.ReadLine());
        char[] Array1 = new char[N];
        char[] Array2 = new char[N];
        for (int index = 0; index < N; index++)
        {
            Console.Write("Array1[{0}]=", index);
            Array1[index] = char.Parse(Console.ReadLine());
            Console.Write("Array2[{0}]=", index);
            Array2[index] = char.Parse(Console.ReadLine());
        }
        for (int index = 0; index < N; index++)
        {
            if (Array1[index] == Array2[index])
            {
                Console.WriteLine("Array1[{0}] = Array2[{0}]", index);
            }
            else
            {
                Console.WriteLine("Array1[{0}] != Array2[{0}]", index);
            }
        }
    }
}