using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] Input = new long[N];
            for (int i = 0; i < N; i++)
            {
                Input[i]=long.Parse(Console.ReadLine()); 
            }
            int[] NumberRep = new int[N];

            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
			    {
			        if (Input[i]==Input[j])
	                {
		                NumberRep[i] += 1;
                        if (i!=j)
                        {
                            NumberRep[j] += 1;
                        }     
                            
	                }
			    }
            }
            for (int i = 0; i < N; i++)
            {
                if (NumberRep[i] % 2 == 1)
                {
                    Console.WriteLine(Input[i]);
                    break;
                }
            }
        }
    }
}
