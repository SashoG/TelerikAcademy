using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two arrays from the console and compares 
//them element by element

class CompareArrays
{
    static void Main(string[] args)
    {
        Console.Write("Enter Arrays dimension:");
        int N = int.Parse(Console.ReadLine());
        int[] Array1 = new int[N];
        int[] Array2 = new int[N];
        for (int index = 0; index < N; index++)
        {
            Console.Write("Array1[{0}]=",index);
            Array1[index] = int.Parse(Console.ReadLine());
            Console.Write("Array2[{0}]=", index);
            Array2[index] = int.Parse(Console.ReadLine());
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
