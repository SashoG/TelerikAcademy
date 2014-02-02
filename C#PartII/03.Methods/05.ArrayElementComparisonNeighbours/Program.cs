using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayElementComparisonNeighbours
{
    class Program
    {
        static int[] InitializeArray()
        {
            Console.Write("Enter number of elements:");
            int numberElements = int.Parse(Console.ReadLine());
            int[] Array = new int[numberElements];
            for (int i = 0; i < numberElements; i++)
            {
                Console.Write("arrayElement[{0}] = ");
                Array[i] = int.Parse(Console.ReadLine());
            }
            return Array;
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
        static bool BiggerThanNeighbours(int elementPos, int[] givenArray)
        {
            bool comparisonNeighbours = false;
            if (GetMax(givenArray[elementPos - 1], givenArray[elementPos]) == givenArray[elementPos] && GetMax(givenArray[elementPos + 1], givenArray[elementPos]) == givenArray[elementPos])
            {
                comparisonNeighbours = true;
            }
            return comparisonNeighbours;
        }
        static bool Validation(int elementPos, int[] givenArray)
        {
            bool valid = false;
            if (elementPos<=givenArray.Length-1 && elementPos>=1)
            {
                valid = true;
            }
            return valid;
        }
        
        static void Main(string[] args)
        {
            int[] givenArray = InitializeArray();
            Console.Write("Enter element position: ");
            int elementPos = int.Parse(Console.ReadLine());
            if (Validation(elementPos,givenArray))
            {
                Console.WriteLine("Element is bigger than neighbours: {0}",BiggerThanNeighbours(elementPos,givenArray));
            }
            else
	        {
                Console.WriteLine("No adjestent position(s) for comparison");
	        }
        }
    }
}
