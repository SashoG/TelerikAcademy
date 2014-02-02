using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
namespace _15.PrimeEratosthenes
{
    class PrimeEratosthenes
    {
        private static List<int> PrimeNumbers(int upperLimit)
        {
            List<int> workList = new List<int>(upperLimit);

            for (int i = 2; i <= upperLimit; i++)
            {
                workList.Add(i);
            }
            workList.TrimExcess();
            bool Flag;
            int j = -1;
            do
            {
                j++;
                Flag = false;
                for (int i = j+1; i < workList.Count; i++)
                {
                    if (workList[i] % workList[j] == 0 )
                    {
                        workList.RemoveAt(i);
                        Flag = true;
                        
                    }
                }
                workList.TrimExcess();
                
            } while (Flag);

            return workList;
        }

        static void Main(string[] args)
        {

            List<int> Primes = PrimeNumbers(1000);
            foreach (var item in Primes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
