using System;

class NumberNotDiv3And7
{
    static void Main()
    {
        Console.Write("Enter number N:");
        string str1 = Console.ReadLine();
        int Num = new int();
        bool err = int.TryParse(str1, out Num);
        if (err != true)
        {
            Console.WriteLine("not an integer");
        }
        for (int i = 1; i < Num; i++)
        {
            if ((i % 7 != 0) | (i % 3 != 0))
            {
                Console.WriteLine(i); 
            }            
        }
    }
}
