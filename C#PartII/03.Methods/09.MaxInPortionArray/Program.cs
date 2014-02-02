using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MaxInPortionArray
{
    class Program
    {
        static List<int> InitializeArray()
        {
            Console.Write("Enter number of elements:");
            int numberElements = int.Parse(Console.ReadLine());
            int[] Array = new int[numberElements];
            for (int i = 0; i < numberElements; i++)
            {
                Console.Write("arrayElement[{0}] = ", i);
                Array[i] = int.Parse(Console.ReadLine());
            }
            return Array.OfType<int>().ToList();
        }
        static int GetMax(int integer1, int integer2)
        {
            int biggerNumber = integer1;
            if (integer1 < integer2)
            {
                biggerNumber = integer2;
            }
            return biggerNumber;
        }
        static int MaxNumber(List<int> inputArray, int position)
        {
            int maxNum = inputArray[0];
            for (int i = position; i < inputArray.Count-1; i++)
            {
                if (maxNum<GetMax(inputArray[i],inputArray[i+1]))
                {
                    maxNum = GetMax(inputArray[i], inputArray[i + 1]);
                }
            }
            return maxNum;
        }
        static List<int> Sort(List<int> inputArray)
        {
            List<int> outputArray = new List<int>();
            int index = inputArray.Count;
            for (int i = 0; i <index ; i++)
            {
                outputArray.Add(MaxNumber(inputArray,0));
                inputArray.Remove(MaxNumber(inputArray,0));

            }
            return outputArray;
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter first array:");
            List<int> Array1 = InitializeArray();
            Console.Write("Enter position in array:");
            int Position = int.Parse(Console.ReadLine());
            Console.WriteLine("Max element in the portion is: {0}", MaxNumber(Array1,Position));
            List<int> sortedArray = Sort(Array1);
            Console.WriteLine("Sorted Array in descending order si:");
            for (int i = 0; i < sortedArray.Count; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }
            Console.WriteLine("Sorted Array in accending order si:");
            for (int i = sortedArray.Count-1; i >=0 ; i--)
            {
                Console.WriteLine(sortedArray[i]);
            }

        }
    }
}
