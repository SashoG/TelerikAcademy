using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] tochar = str.ToCharArray();
            char[] reversedStr = tochar.Reverse().ToArray();

            Console.WriteLine(reversedStr);
        }
    }
}
