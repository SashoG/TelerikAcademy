using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the smallest from the rest,
//move it at the second position, etc.

class SortArray
{
    static void Main(string[] args)
    {
        Console.Write("Enter Array dimension:");
        int N = int.Parse(Console.ReadLine());
        int[] Array = new int[N];
        int[] SortedArray = new int[N];
        for (int index = 0; index < N; index++)
        {
            Console.Write("Array[{0}]=", index);
            Array[index] = int.Parse(Console.ReadLine());
        }        
        int i = 0;
        int minindex = 0;
        do
        {
            int minValue = Int32.MaxValue;
            for (int index = 0; index < N; index++)
            {
                if (Array[index] < minValue )
                {
                    minValue = Array[index];
                    minindex = index;
                }
            }
            Array[minindex] = Int32.MaxValue;
            SortedArray[i] = minValue;
            i++;
        } while (i<N);
        for (int index = 0; index < N; index++)
        {
            Console.WriteLine(SortedArray[index]);
        }
       
    }
}
