using System;

    class Sort3Real
    {
        static void Main()
        {

            Console.Write("Enter real number 1:");
            string str1 = Console.ReadLine();
            double rn1 = double.Parse(str1);
            Console.Write("Enter real number 2:");
            string str2 = Console.ReadLine();
            double rn2 = double.Parse(str2);
            Console.Write("Enter real number 3:");
            string str3 = Console.ReadLine();
            double rn3 = double.Parse(str3);
            if (rn1 == rn2 | rn1 == rn3 | rn2 == rn3)
            {
                Console.WriteLine("Please enter different numbers");
            }
            else
            {
                if (rn1 > rn2)
                {
                    if (rn2 > rn3)
                    {
                        Console.WriteLine("Numbers in descending order are {0}, {1}, {2}", rn1, rn2, rn3);
                    }
                    if (rn3 > rn1)
                    {
                        Console.WriteLine("Numbers in descending order are {0}, {1}, {2}", rn3, rn1, rn2);
                    }
                }
                else
                {
                    if (rn1 > rn3)
                    {
                        Console.WriteLine("Numbers in descending order are {0}, {1}, {2}", rn2, rn1, rn3);
                    }
                    if (rn2 < rn3)
                    {
                        Console.WriteLine("Numbers in descending order are {0}, {1}, {2}", rn3, rn2, rn1);
                    }
                }
                if (rn3 > rn2)
                {
                    if (rn1 > rn3)
                    {
                        Console.WriteLine("Numbers in descending order are {0}, {1}, {2}", rn1, rn3, rn2);
                    }

                }
                else
                {
                    if (rn3 > rn1)
                    {
                        Console.WriteLine("Numbers in descending order are {0}, {1}, {2}", rn2, rn3, rn1);
                    }
                }
            }
        }
    }
