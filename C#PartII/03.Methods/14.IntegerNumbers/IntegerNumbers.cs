using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerNumbers
{
    class IntegerNumbers
    {
        private static List<int> InitializeSequenceIntegers()
        {
            Console.WriteLine("Enter sequence of integers. When done write: exit");
            List<int> output = new List<int>();
            int i = 0;
            do
            {
                do
                {
                    i++;
                    Console.Write("Enter integer {0}: ", i);
                    string str = Console.ReadLine();
                    if (str == "exit")
                    {
                        break;
                    }
                    else
                    {
                        output.Add(int.Parse(str));
                    }
                } while (true);
                if (output.Count == 0)
                {
                    Console.WriteLine("Please eneter at least 1 integer");
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);

            return output;
        }
        private static int MinNumber(List<int> inputList)
        {
            int MinNum = Int32.MaxValue;
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i]<MinNum)
                {
                    MinNum = inputList[i];
                }
            }
            return MinNum;
        }
        private static int MaxNumber(List<int> inputList)
        {
            int MaxNum = Int32.MinValue;
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] > MaxNum)
                {
                    MaxNum = inputList[i];
                }
            }
            return MaxNum;
        }
        private static int Average(List<int> input)
        {
            int result = 0;
            for (int i = 0; i < input.Count; i++)
            {
                result += input[i];
            }
            return result /= input.Count;
        }
        private static int Sum(List<int> input)
        {
            int result = 0;
            for (int i = 0; i < input.Count; i++)
            {
                result += input[i];
            }
            return result ;
        }
        private static int Product(List<int> input)
        {
            int result = 1;
            for (int i = 0; i < input.Count; i++)
            {
                result *= input[i];
            }
            return result;
        }
        
        static void Main(string[] args)
        {
            List<int> integers = InitializeSequenceIntegers();
            Console.WriteLine("Minimum number in the set: {0} ",MinNumber(integers));
            Console.WriteLine("Maximum number in the set: {0} ", MaxNumber(integers));
            Console.WriteLine("Sum the set: {0} ", Sum(integers));
            Console.WriteLine("Product of the set: {0} ", Product(integers));
        }
    }
}
