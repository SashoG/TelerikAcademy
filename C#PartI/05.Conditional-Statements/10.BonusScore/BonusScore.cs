using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter digit:");
        string str1 = Console.ReadLine();
        byte digit;
        bool parsesucc = byte.TryParse(str1, out digit);
        if (parsesucc == false)
        {
            Console.WriteLine("You have not entered a valid digit/number");
        }
        else
        {
            switch (digit)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("New value is x10:{0}", digit * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("New value is x100:{0}", digit * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("New value is x1000:{0}", digit * 1000);
                    break;
                case 0:
                default:
                    Console.WriteLine("Error");
                    break;
                }        
        }
    }
}
