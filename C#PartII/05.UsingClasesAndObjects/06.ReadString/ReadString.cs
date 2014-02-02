using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReadString
{
    class ReadString
    {


        static void Main(string[] args)
        {
            string str = "1 34 56 678 23";
            int indexStart = 0;
            int indexEnd = 0;
            List<int> numbers = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                indexEnd = str.IndexOf(' ', indexStart) - 1;
                if (indexEnd<0)
                {
                    numbers.Add(Convert.ToInt32(str.Substring(indexStart, str.Length - indexStart)));
                    break;
                }
                numbers.Add(Convert.ToInt32(str.Substring(indexStart,indexEnd-indexStart+1)));
                indexStart = indexEnd + 2;
            }
            int Sum = numbers.Sum();
            Console.WriteLine("Sum is: {0} ",Sum);

        }
    }
}
