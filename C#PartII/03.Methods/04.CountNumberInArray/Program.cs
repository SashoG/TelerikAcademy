using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountNumberInArray
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
        static int CountNumberAppearance(int number, int[] givenArray)
        {
            int countNumberApp = 0;
            for (int i = 0; i < givenArray.Length; i++)
            {
                if (number==givenArray[i])
                {
                    countNumberApp++;
                }
            }
            return countNumberApp;
        }
              
        static void Main(string[] args)
        {
            int[] givenArray = InitializeArray();
            Console.Write("Enter number to look for: ");
            int number = int.Parse(Console.ReadLine());
            int countNumberApp = CountNumberAppearance(number, givenArray);
            Console.WriteLine("Number {0} appears {1} in the array", number,countNumberApp);
        }
    }
}
