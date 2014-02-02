using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Problem1
{
    class MathExpresion
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            decimal N = decimal.Parse(Console.ReadLine());
            decimal M = decimal.Parse(Console.ReadLine());
            decimal P = decimal.Parse(Console.ReadLine());

            decimal Result = (N * N + (1M / (M * P)) + 1337M) / (N - 128.523123123M * P) + (decimal)Math.Sin((int)(M % 180));

            Console.WriteLine("{0:0.000000}", Result);

        }
    }
}
