using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxNumber
{
    class Program
    {
        static int GetMax(int integer1, int integer2)
        {
            int biggerNumber = integer1;
            if (integer1<integer2)
            {
                biggerNumber = integer2;
            }
            return biggerNumber; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 integers:");
            int Int1 = int.Parse(Console.ReadLine());
            int Int2 = int.Parse(Console.ReadLine());
            int Int3 = int.Parse(Console.ReadLine());
            int maxOutOfThree = GetMax(GetMax(Int1, Int2), GetMax(Int2, Int3));
            Console.WriteLine("The maximal number is: {0}", maxOutOfThree);
        }
    }
}
