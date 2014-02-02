using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.EncodingDecoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string:");
            string message = Console.ReadLine();
            Console.Write("Enter cipher:");
            string cipher = Console.ReadLine();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                builder.Append((char)(message[i] ^ cipher[i % cipher.Length]));
            }
            Console.WriteLine("Encrypted string: " + builder.ToString());
        }
    }
}
