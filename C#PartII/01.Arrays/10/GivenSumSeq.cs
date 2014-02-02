using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

class GivenSumSeq
{
    static void Main(string[] args)
    {
        Console.Write("Enter Array dimension:");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter Sum:");
        int S = int.Parse(Console.ReadLine());
        int[] Array = new int[N];
        for (int index = 0; index < N; index++)
        {
            Console.Write("Array[{0}]=", index);
            Array[index] = int.Parse(Console.ReadLine());
        }
        int currentSum = 0;
        List<int> Index1 = new List<int>(); //should there is more than one sequence with the desired sum
        List<int> Index2 = new List<int>();
        for (int i = 0; i < N; i++)
        {
            for (int j = i; j < N; j++)
            {
                currentSum += Array[j];
                if (currentSum==S)
                {
                    Index1.Add(i);
                    Index2.Add(j);
                }
            }
            currentSum = 0;
        }
        for (int i = 0; i <  Index1.Count; i++)
        {
            for (int j = Index1[i]; j <= Index2[i]; j++)
            {
                Console.Write("{0} ", Array[j]);
            }
            Console.WriteLine();
        }
    }
}
