using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumIntegers
{
    class Program
    {
        static int[] InitializeArray()
        {
            Console.Write("Enter number of digits:");
            int numberElements = int.Parse(Console.ReadLine());
            int[] Array = new int[numberElements];
            for (int i =0; i <numberElements ; i++)
            {
                Console.Write("digit[{0}] = ",i);
                Array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("You have entered the integer:");
            for (int i = Array.Length-1; i >= 0; i--)
            {
                Console.Write(Array[i]);
            }
            Console.WriteLine();
            return Array;
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
        static int[] ArraySum(int[] Array1, int[] Array2)
        {
            int[] Sum = new int[GetMax(Array1.Length,Array2.Length)+1];
            if (Array1.Length>Array2.Length)
	        {
                for (int i = 0; i <Array2.Length ; i++)
			    {
                    if (Array1[i] + Array2[i] < 10)
                    {
                        Sum[i] += Array1[i] + Array2[i];
                    }
                    else
                    {
                        Sum[i] += (Array1[i] + Array2[i]) % 10;
                        Sum[i - 1] += 1;
                    }
                    if (Sum[i] > 10)
                    {
                        Sum[i] %= 10;
                        Sum[i + 1] += 1;
                    }    
			    }
                for (int i = Array2.Length; i < Array1.Length; i++)
			    {
                    Sum[i] += Array1[i];
                    if (Sum[i] > 10)
                    {
                        Sum[i] %= 10;
                        Sum[i + 1] += 1;
                    } 
			    }
	        }
            else
            {
                for (int i = 0; i < Array1.Length; i++)
                {
                    if (Array1[i] + Array2[i] < 10)
                    {
                        Sum[i] += Array1[i] + Array2[i];
                    }
                    else
                    {
                        Sum[i] += (Array1[i] + Array2[i]) % 10;
                        Sum[i - 1] += 1;
                    }
                    if (Sum[i] > 10)
                    {
                        Sum[i] %= 10;
                        Sum[i + 1] += 1;
                    }
                }
                for (int i = Array1.Length; i < Array2.Length; i++)
                {
                    Sum[i] += Array2[i];
                    if (Sum[i] > 10)
                    {
                        Sum[i] %= 10;
                        Sum[i + 1] += 1;
                    }
                }
            }
            return Sum;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Eneter first integer by digits:");
            int[] Array1 = InitializeArray();
            Console.WriteLine("Eneter second integer by digits:");
            int[] Array2 = InitializeArray();
            int[] arraySum = ArraySum(Array1, Array2);
            Console.Write("Sum is:");
            for (int i = arraySum.Length-1; i >= 0; i--)
            {
                if (i == arraySum.Length-1 && arraySum[i] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.Write(arraySum[i]);
                }
                
            }
            Console.WriteLine();

        }
    }
}
