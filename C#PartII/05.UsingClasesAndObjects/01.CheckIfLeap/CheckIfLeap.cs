using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CheckIfLeap
{
    class CheckIfLeap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter date in the format: dd,mm,yyyy");
            DateTime dateFromConsole = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Is {0} leap year: {1}", dateFromConsole.Year, DateTime.IsLeapYear(dateFromConsole.Year));
        }
    }
}
