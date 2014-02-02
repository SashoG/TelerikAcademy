using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10.ExtractText
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("SomeXML.xml");
            using (reader)
            {
                for (int currentSymbol; (currentSymbol = reader.Read()) != -1; )
                {
                    if (currentSymbol == '>')
                    {
                        string readText = string.Empty;
                        while (((currentSymbol = reader.Read()) != -1) && (currentSymbol != '<'))
                        {
                            readText += (char)currentSymbol;
                        }
                        Console.Write(readText.Trim() + " ");
                    }
                }
            }
            
        }
    }
}
