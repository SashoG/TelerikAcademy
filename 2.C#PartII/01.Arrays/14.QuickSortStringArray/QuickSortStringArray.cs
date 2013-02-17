using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).


namespace _14.QuickSortStringArray
{
    class QuickSortStringArray
    {
        private static List<string> QuickSort(List<string> inputArray)
        {
            if (inputArray.Count <= 1)
            {
                return inputArray;
            }
            else
            {
                List<string> Less = new List<string>();
                List<string> Greater = new List<string>();
                List<string> Pivot = new List<string>();
                Pivot.Add(inputArray[inputArray.Count - 1]);
                inputArray.RemoveAt(inputArray.Count - 1);
                foreach (string el in inputArray)
                {
                    if (String.Compare(el, Pivot[0], true) <= 0)      //dictionary-based comparison
                    {
                        Less.Add(el);
                    }
                    else
                    {
                        Greater.Add(el);
                    }
                }
                return Concatenate3StringLists(QuickSort(Less),Pivot, QuickSort(Greater));
            }
        }

        private static List<string> Concatenate3StringLists(List<string> List1, List<string> List2, List<string> List3)
        {
            List<string> output = new List<string>();
            foreach (var item in List1)
            {
                output.Add(item);
            }
            foreach (var item in List2)
            {
                output.Add(item);
            }
            foreach (var item in List3)
            {
                output.Add(item);
            }
            return output;
        }


        static void Main(string[] args)
        {
            List<string> arr = new List<string>() { "fsd", "aser", "asdfwea", "waojsepofmps", "a", "df", "ohojm", "owdookdeomc", "dfr" };
            List<string> sorted = new List<string>();
            sorted = QuickSort(arr);
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
