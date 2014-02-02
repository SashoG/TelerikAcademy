using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomValues
{
    class RandomValues
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Random randomValue = new Random();
            do
            {
                Console.WriteLine(randomValue.Next(100, 200));
                counter++;
            }
            while (counter < 10);


        }
    }
}
