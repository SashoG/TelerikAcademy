using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.BinaryRepresentation
{
    class BinaryRepresentation
    {
        static void Main(string[] args)
        {
            short Number = new short();
            Number = -123;
            Console.WriteLine(Convert.ToString(Number, 2).PadLeft(16, '0'));
        }
    }
}
