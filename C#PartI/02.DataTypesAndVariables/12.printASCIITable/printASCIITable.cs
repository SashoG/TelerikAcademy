using System;

    class printASCIITable
    {
        static void Main()        
        {
            Console.WriteLine("ASCII Table Characters:");
            for (int i = 1; i <= 256; i++)
            {
                Console.WriteLine((char)i);
            }              
        }
        
    }
