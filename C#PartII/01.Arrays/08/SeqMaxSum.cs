using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?


class SeqMaxSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter Array Dimension:");
        int N = int.Parse(Console.ReadLine());
        int[] Array = new int[N];
        for (int index = 0; index < N; index++)
        {
            Console.Write("Array[{0}] = ", N);
            Array[index] = int.Parse(Console.ReadLine());
        }
        int MaxSum = Int32.MinValue;
        int CurrentSum = new int();
        int leftEndIndex = 0;
        int rightEndIndex = 0;
        for (int index1 = 0; index1 < N; index1++)
		{
			    for (int index2 = index1; index2 < N; index2++)
			    {
			        CurrentSum+=Array[index2];
                    if (CurrentSum>MaxSum)
	                {
		                MaxSum=CurrentSum;
                        leftEndIndex = index1;
                        rightEndIndex = index2;
	                }
			    }
            CurrentSum=0;       
		}
        Console.Write("{");
        for (int index =leftEndIndex; index <= rightEndIndex; index++)
			{
			 Console.Write(" {0} ", Array[index]);
			}
        Console.WriteLine("}");
    }
}
