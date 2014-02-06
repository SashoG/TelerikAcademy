using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            var gsmTest = new GsmTest();
            Console.WriteLine(gsmTest.ShowInfoTestArray());
            Console.WriteLine(gsmTest.ShowInfoIPhone4S());
        }
    }
}