using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChangeTextInTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='<')
                {
                    i += 8;
                    while (text[i]!='<')
                    {
                        builder.Append(text[i].ToString().ToUpper());
                        i++;
                    }
                    i += 9;                        
                }
                builder.Append(text[i]);
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
