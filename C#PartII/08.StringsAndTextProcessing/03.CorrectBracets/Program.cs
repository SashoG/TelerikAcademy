using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CorrectBracets
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int opened = 0;
            int closed = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]=='(')
                {
                    opened++;
                }
                else if (str[i] == ')')
                {
                    closed++;
                }
                
            }
            Console.WriteLine(opened==closed?"correct":"inccorect");
        }
    }
}
