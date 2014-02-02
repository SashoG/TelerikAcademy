using System;

class PronounceNum
{
    static void Main()
    {
        Console.Write("Enter number in the range [0-999]:");
        string str1 = Console.ReadLine();
        int number;
        bool parsesucc = int.TryParse(str1, out number);
        if (parsesucc & number<999 & number>0)
        {
            int hun = number / 100;
            int ten = (number % 100) / 10;
            int one = (number % 100) % 10;
            switch (hun)
            {
                case 1:
                    Console.Write("One hundred");
                    break;
                case 2:
                    Console.Write("Two hundred");
                    break;
                case 3:
                    Console.Write("Three hundred");
                    break;
                case 4:
                    Console.Write("Four hundred");
                    break;
                case 5:
                    Console.Write("Five hundred");
                    break;
                case 6:
                    Console.Write("Six hundred");
                    break;
                case 7:
                    Console.Write("Seven hundred");
                    break;
                case 8:
                    Console.Write("Eight hundred");
                    break;
                case 9:
                    Console.Write("Nine hundred");
                    break;
            }
            if (ten==1)
            {
                switch (one)
                {
                    case 1:
                        Console.Write(" eleven\n");
                        break;
                    case 2:
                        Console.Write(" twelve\n");
                        break;
                    case 3:
                        Console.Write(" thirteen\n");
                        break;
                    case 4:
                        Console.Write(" fourteen\n");
                        break;
                    case 5:
                        Console.Write(" fifteen\n");
                        break;
                    case 6:
                        Console.Write(" sixteen\n");
                        break;
                    case 7:
                        Console.Write(" seventeen\n");
                        break;
                    case 8:
                        Console.Write(" eighteen\n");
                        break;
                    case 9:
                        Console.Write(" ninteen\n");
                        break;
                }
            }
            else
            {
                switch (ten)
                {
                    case 2:
                        Console.Write(" twenty");
                        if (one==0)
                        {
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.Write(" thurty");
                        if (one == 0)
                        {
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.Write(" fourty");
                        if (one == 0)
                        {
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        Console.Write(" fifty");
                        if (one == 0)
                        {
                            Console.WriteLine();
                        }
                        break;
                    case 6:
                        Console.Write(" sixty");
                        if (one == 0)
                        {
                            Console.WriteLine();
                        }
                        break;
                    case 7:
                        Console.Write(" seventy");
                        if (one == 0)
                        {
                            Console.WriteLine();
                        }
                        break;
                    case 8:
                        Console.Write(" eigthy");
                        if (one == 0)
                        {
                            Console.WriteLine();
                        }
                        break;
                    case 9:
                        Console.Write(" ninty");
                        if (one == 0)
                        {
                            Console.WriteLine();
                        }
                        break;
                }
            }
            switch (one)
            {
                case 1:
                    Console.Write(" one\n");
                    break;
                case 2:
                    Console.Write(" two\n");
                    break;
                case 3:
                    Console.Write(" three\n");
                    break;
                case 4:
                    Console.Write(" four\n");
                    break;
                case 5:
                    Console.Write(" five\n");
                    break;
                case 6:
                    Console.Write(" six\n");
                    break;
                case 7:
                    Console.Write(" seven\n");
                    break;
                case 8:
                    Console.Write(" eight\n");
                    break;
                case 9:
                    Console.Write(" nine \n");
                    break;
            }
           
        }
        else
        {
            Console.WriteLine("You have not entered a valid number");
        }
    }
}
