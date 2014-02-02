using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11.PolynomialSumation
{
    class PolynomialSumation
    {
        private static decimal[] InitializePolynom(int highestPower)
        {
            decimal[] outputArr = new decimal[highestPower];
            for (int i = 0; i < highestPower; i++)
            {
                Console.Write("Enter coefficent infront of power {0}:",i);
                outputArr[i] = decimal.Parse(Console.ReadLine());
            }
            return outputArr;
        }
        private static void PrintPolynom(decimal[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] != 0)
                {
                    Console.Write("{0}*x^{1} +", arr[i], i);
                }

            }
            if (arr[0] != 0)
            {
                Console.Write("{0} +", arr[0]);
            }

            Console.WriteLine("\b= 0");
            return;
        }

        static int GetMax(int integer1, int integer2)
        {
            int biggerNumber = integer1;
            if (integer1 < integer2)
            {
                biggerNumber = integer2;
            }
            return biggerNumber;
        }

        static decimal[] ArraySum(decimal[] Array1, decimal[] Array2)
        {
            decimal[] Sum = new decimal[GetMax(Array1.Length, Array2.Length) + 1];
            if (Array1.Length > Array2.Length)
            {
                for (int i = 0; i < Array2.Length; i++)
                {
                    Sum[i] += Array1[i] + Array2[i];
                }
                for (int i = Array2.Length; i < Array1.Length; i++)
                {
                    Sum[i] += Array1[i];
                }
            }
            else
            {
                for (int i = 0; i < Array1.Length; i++)
                {
                    Sum[i] += Array1[i] + Array2[i];
                }
                for (int i = Array1.Length; i < Array2.Length; i++)
                {
                    Sum[i] += Array2[i];
                }
            }
            return Sum;
        }

        
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture =  CultureInfo.InvariantCulture;

            Console.Write("Enter highest power first polynom: ");
            int powerPolynom1 = int.Parse(Console.ReadLine());
            Console.Write("Enter highest power second polynom: ");
            int powerPolynom2 = int.Parse(Console.ReadLine());
            decimal[] polynom1 = InitializePolynom(powerPolynom1);
            decimal[] polynom2 = InitializePolynom(powerPolynom2);
            Console.Write("First Polynom: ");
            PrintPolynom(polynom1);
            Console.Write("Second Polynom: ");
            PrintPolynom(polynom2);
            decimal[] result = ArraySum(polynom1, polynom2);
            Console.Write("Sumation result: ");
            PrintPolynom(result);

        }
    }
}
