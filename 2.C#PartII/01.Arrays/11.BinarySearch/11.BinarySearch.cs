using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the index of given element in a sorted array of integers by using
//the binary search algorithm (find it in Wikipedia).


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Array Dimension:");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter Searched Element:");
        int E = int.Parse(Console.ReadLine());
        int[] MyArray = new int[N];
        Console.WriteLine("Enter Sorted Array(ascending):");
        for (int index = 0; index < N; index++)
        {
            Console.Write("MyArray[{0}] = ", index);
            MyArray[index] = int.Parse(Console.ReadLine());
        }
        int CenterIndex = MyArray.Length / 2;
        bool flag = true;
        do
        {
            if (E < MyArray[CenterIndex])
            {
                CenterIndex /= 2;
            }
            if (E > MyArray[CenterIndex])
            {
                CenterIndex = CenterIndex + CenterIndex / 2;
            }
            if (E == MyArray[CenterIndex])
            {
                Console.WriteLine("Index of searched element is: {0}", CenterIndex);
                flag = false;
            }
        } while (flag);

    }
}