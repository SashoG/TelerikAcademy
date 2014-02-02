using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)


class MostFreqNum
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
        //sort the array in accending order
        int i = 0;
        int minindex = 0;
        do
        {
            int minValue = Int32.MaxValue;
            for (int index = 0; index < N; index++)
            {
                if (Array[index] < minValue)
                {
                    minValue = Array[index];
                    minindex = index;
                }
            }
            Array[minindex] = Int32.MaxValue;
            SortedArray[i] = minValue;
            i++;
        } while (i < N);
        //find equal elements consequently scaning the array
        int counter = 0;
        int Maxcounter = 0;
        int MostFreqEl = 0;
        for (int index = 0; index < N-1; index++)
        {
            if (SortedArray[index] == SortedArray[index + 1])
            {
                counter++;
            }
            else 
            {
                if (counter > Maxcounter)
                {
                    Maxcounter = counter + 1;
                    MostFreqEl = SortedArray[index - 1];
                }
                counter = 0;
            }
        }
        counter = 0;
        //check if there is more than one most frequent number (for example there two numbers with equal frequency, which happens to be the maximal frequency
        List<int> MostFreqRep = new List<int>();
        for (int index = 0; index < N-1; index++)
        {
            if (SortedArray[index] == SortedArray[index + 1])
            {
                counter++;
            }
            else 
            {
                if (counter == Maxcounter-1)
                {
                    MostFreqRep.Add(SortedArray[index-1]);
                }
                counter = 0;
            }    
        }
        foreach (var repeated in MostFreqRep)
	    {
		     Console.WriteLine("{0}({1} times)",repeated, Maxcounter);
	    }
    }
}
