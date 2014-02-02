using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortStringsByLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = { "er", "asdf", "as", "asdfghj", "asd", "w", "wqertfdsadsf", "ads" };
            Array.Sort(arrayOfStrings, (x,y) => x.Length.CompareTo(y.Length));
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                Console.Write(arrayOfStrings[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
