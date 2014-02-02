using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReadString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            string str = Console.ReadLine();
            if (str.Length < 20)
            {
                builder.Append(str);
                builder.Append('*', 20 - str.Length);
            }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    builder.Append(str[i]);
                }
                
            }
            Console.WriteLine(builder.ToString());
            
            
        }
    }
}
