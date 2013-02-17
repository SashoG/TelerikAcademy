using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the maximal sequence of equal elements in an array.
		//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.


class MaximalSequenceEqualsInArray
{
    static void Main(string[] args)
    {
        Console.Write("Enter Array dimension:");
        int N = int.Parse(Console.ReadLine());
        int[] Array = new int[N];
        for (int index = 0; index < N; index++)
        {
            Console.Write("Array[{0}]=", index);
            Array[index] = int.Parse(Console.ReadLine());
        }
        int GroupNum = 0;
        int MaxGroupNum = 0;
        int maxIndex = 0;
        List<int> RepeatedGroups = new List<int>();
        for (int index = 0; index < N-1; index++)
        {
            if (Array[index] == Array[index + 1])
            {
                GroupNum++;
                if (GroupNum>MaxGroupNum)
                {
                    MaxGroupNum = GroupNum;
                    maxIndex = index;
                }
            }
            else
            {
                GroupNum = 0;
            }
        }
        //check if there is more than one group 
        for (int index = 0; index < N - 1; index++)
        {
            if (Array[index] == Array[index + 1])
            {
                GroupNum++;
                if (GroupNum == MaxGroupNum)
                {
                    RepeatedGroups.Add(index);
                }
            }
            else
            {
                GroupNum = 0;
            }
        }
        Console.Write("Maximal sequence of equal elements is  ");
        foreach (var RepeatedIndex in RepeatedGroups)
        {
            Console.Write("{ ");
            for (int index = 0; index < MaxGroupNum + 1; index++)
            {
                Console.Write("{0} ", Array[RepeatedIndex]);
            }
            Console.Write("} ");
        }
    }
}
