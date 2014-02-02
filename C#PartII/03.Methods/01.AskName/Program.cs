using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AskName
{
    class Program
    {
        static void AskName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}",name);
        }
        static void Main(string[] args)
        {
            AskName();
        }
    }
}
