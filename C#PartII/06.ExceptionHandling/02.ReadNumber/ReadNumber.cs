using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReadNumber
{
    class Program
    {
        private static int ReadNumber(int start, int end)
        {

            Console.Write("Enter integer number in the range [{0}...{1}]: ", start, end);
            int output = int.Parse(Console.ReadLine());
            if (output < start | output > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return output;

        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            int start = 1;
            do
            {
                try
                {
                    int enteredNum = ReadNumber(start, 100);
                    arr.Add(enteredNum);
                    start = enteredNum +1;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Invalid Number");

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number");

                }
            } while (arr.Count < 10);
            Console.WriteLine("Entered Numbers");
            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }



        }
    }
}
