using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.StringToUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hi!";
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write("\\u{0:X4}",(int)chars[i]);
            }
            Console.WriteLine();
        }
    }
}
