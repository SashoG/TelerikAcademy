using System;

class SumCalc
{
    static void Main()
    {
        double Sum = 1;
        int counter = 1;
        Console.Write("1");
        while ((1.0/counter)>0.001)
        {
            counter++;
            Sum += Math.Pow(-1,counter)*(1.0/counter);
            Console.Write("+ 1/{0}", counter );
        }
        Console.WriteLine("= {0:0.000}",Sum);
    }
}
