using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the maximal increasing sequence in an array. 
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


class MaximalIncreasingSeq
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
        for (int index = 1; index < N; index++)
        {
            if (Array[index] > Array[index - 1])
            {
                GroupNum++;
                if (GroupNum > MaxGroupNum)
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
        for (int index = 1; index < N; index++)
        {
            if (Array[index] > Array[index - 1])
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
            for (int index = RepeatedIndex - maxIndex; index <= RepeatedIndex; index++)
            {
                Console.Write("{0} ", Array[index]);
            }
            Console.Write("} ");
        }
    }
}
