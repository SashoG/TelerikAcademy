using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

class MaxSum
{
    static void Main(string[] args)
    {
        Console.Write("N = ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int K = int.Parse(Console.ReadLine());
        int[] Array = new int[N];
        for (int index = 0; index < N; index++)
        {
            Console.Write("Array[{0}] = ", index);
            Array[index] = int.Parse(Console.ReadLine());
        }
        int[] SortedArray = new int[N];
        int i = 0;
        int maxindex = 0;
        Console.Write("The {0} elemnets with maximal sum are:", K);
        do
        {
            int maxValue = Int32.MinValue;
            for (int index = 0; index < N; index++)
            {
                if (Array[index] > maxValue)
                {
                    maxValue = Array[index];
                    maxindex = index;
                }
            }
            Console.Write(" {0}", Array[maxindex]);
            Array[maxindex] = Int32.MinValue;
            i++;
        } while (i < K);
        Console.WriteLine("}");

    }
}
