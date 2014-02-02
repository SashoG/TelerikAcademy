using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TryCatchFinallySqrtNum
{
    class TryCatchFinallySqrtNum
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new Exception();
                }
                Console.WriteLine("Square Root of {0} is {1:F5} ", number, Math.Sqrt(number));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good buy");
            }

        }
    }
}
