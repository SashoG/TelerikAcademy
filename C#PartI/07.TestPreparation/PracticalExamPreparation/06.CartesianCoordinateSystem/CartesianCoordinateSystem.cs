using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CartesianCoordinateSystem
{
    class CartesianCoordinateSystem
    {
        static void Main(string[] args)
        {
            decimal X = decimal.Parse(Console.ReadLine());
            decimal Y = decimal.Parse(Console.ReadLine());
            byte Output = new byte();
            if (X>0&&Y>0)
            {
                Output = 1;
            }
            if (X<0&&Y>0)
            {
                Output = 2;
            }
            if (X<0&&Y<0)
            {
                Output = 3;
            }
            if (X>0&&Y<0)
            {
                Output = 4;
            }
            if (X==0&&Y!=0)
            {
                Output = 5;
            }
            if (Y==0&&X!=0)
            {
                Output = 6;
            }
            if (X==0&&Y==0)
            {
                Output = 0;
            }
            Console.WriteLine(Output);
        }
    }
}
