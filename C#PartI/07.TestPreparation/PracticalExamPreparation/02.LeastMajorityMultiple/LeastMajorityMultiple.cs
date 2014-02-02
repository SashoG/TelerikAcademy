using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LeastMajorityMultiple
{
    class LeastMajorityMultiple
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int i = 0;
            int j = 0;
            do
            {
                i++;
                j = 0;
                if (i%a==0)
                {
                    j++; 
                }
                if (i%b==0)
                {
                    j++;   
                }
                if (i%c==0)
                {
                    j++;
                }
                if (i%d==0)
                {
                    j++;
                }
                if (i%e==0)
                {
                    j++;
                }
            } while (j<3);
            Console.WriteLine(i);
        }
    }
}
