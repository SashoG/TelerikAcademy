using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PrintNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Number as a decimal: {0,15}", num);
            Console.WriteLine("Number as a hexadecimal: {0,15:x}", num);
            Console.WriteLine("Number as a percentage: {0,15:P}", num);
            Console.WriteLine("Number in scientific notation: {0,15:E}", num);
            
        }
    }
}
