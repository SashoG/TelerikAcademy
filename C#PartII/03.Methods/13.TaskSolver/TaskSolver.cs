using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TaskSolver
{
    class TaskSolver
    {
        static int CountDigits(decimal inputNumber)
        {
            int digitCount = 0;
            do
            {
                inputNumber /= 10;
                digitCount++;
            } while (inputNumber >= 1);
            return digitCount;
        }

        static decimal ReverseDigits(decimal inputNumber)
        {
            decimal reversedNumber = 0;
            int digCount = CountDigits(inputNumber);
            for (int i = 0; i < digCount; i++)
            {
                reversedNumber += (inputNumber % 10) * Convert.ToDecimal(Math.Pow(10, digCount - i - 1));
                inputNumber /= 10;
                inputNumber = decimal.Truncate(inputNumber);
            }
            return reversedNumber;
        }
        private static bool ValidateDecimal(decimal inputNum)
        {
            bool flag = false;
            if (inputNum < 0)
            {
                Console.Write("You have enetered a negative number. Try again");
                return flag = true;
            }
            return flag;
        }
        private static List<int> InitializeSequenceIntegers()
        {

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
        private static int AverageIntegers(List<int> input)
        {
            int result = 0;
            for (int i = 0; i < input.Count; i++)
            {
                result += input[i];
            }
            return result /= input.Count;
        }
        private static void SolveLinearEquation()
        {
            decimal a;
            do
            {
                Console.Write("Enter coefficent a:");
                a = decimal.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("a cannot be zero!");
                }
                else
                {
                    break;
                }
            } while (true);
            Console.Write("Enter coefficent b:");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal result = -b / a;
            Console.WriteLine("Result is: x = {0} ",result);
            return;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an option number:");
            Console.WriteLine("1 for reversing the digits of a decimal number");
            Console.WriteLine("2 for average of integer sequence");
            Console.WriteLine("3 for linear equation solver");
            int option = new int();
            option = int.Parse(Console.ReadLine());
            decimal number = new decimal();
            switch (option)
            {
                case 1:
                    {
                        Console.Write("Enter non-negative decimal:");
                        do
                        {
                            number = decimal.Parse(Console.ReadLine());
                        } while (ValidateDecimal(number));

                        Console.WriteLine("Reversed number is: {0}", ReverseDigits(number));
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Enter sequence of integers. When done write: exit");
                        List<int> arrInt = InitializeSequenceIntegers();
                        int average = AverageIntegers(arrInt);
                        Console.WriteLine("Averange of the sequence is:{0} ", average);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Solving equation of the type: a*x+b=0");
                        SolveLinearEquation();
                    }
                    break;
            }

        }
    }
}
