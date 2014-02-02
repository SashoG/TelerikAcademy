using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _12.ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.devbg.org/forum/index.php";
            var parts = Regex.Match(url, "(.*)://(.*?)(/.*)").Groups;
            Console.WriteLine(parts[1]);
            Console.WriteLine(parts[2]);
            Console.WriteLine(parts[3]);
        }
    }
}
