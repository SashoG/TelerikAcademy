using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LargestNumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of integers: ");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            for (int index = 0; index < N; index++)
            {
                Console.Write("{0} integer : ", index);
                arr[index] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter integer K: ");
            int K = int.Parse(Console.ReadLine());
            Array.Sort(arr, (x, y) => x.CompareTo(y));
            int number = new int();
            number = Array.BinarySearch(arr, K);
            
            
            if (number > 0)
                {
                    Console.WriteLine("Largest number in the array is equal to K: {0}", K);
                }
            else 
                {
                    while (number< 0)
                    {
                        K--;
                        number = Array.BinarySearch(arr, K);
                    }
                    Console.WriteLine("Largest number in the array which is smaller or equal to K: {0}", arr[number]);
                }
          
        }
    }
}
