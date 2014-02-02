using System;

class Cards
{
    static void Main()
    {
        string[] Cardkind = new string[] {"Hearts","Clubs", "Spades","Diamonds"};
        for (int j = 0; j <= 3; j++)
        {
            for (int i = 1; i <= 13; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Ace of " + Cardkind[j]);
                        break;
                    case 2:
                        Console.WriteLine("Two of " + Cardkind[j]);
                        break;
                    case 3:
                        Console.WriteLine("Three of " + Cardkind[j]);
                        break;
                    case 4:
                        Console.WriteLine("Four of " + Cardkind[j]);
                        break;
                    case 5:
                        Console.WriteLine("Five of " + Cardkind[j]);
                        break;
                    case 6:
                        Console.WriteLine("Six of " + Cardkind[j]);
                        break;
                    case 7:
                        Console.WriteLine("Seven of " + Cardkind[j]);
                        break;
                    case 8:
                        Console.WriteLine("Eight of " + Cardkind[j]);
                        break;
                    case 9:
                        Console.WriteLine("Nine of " + Cardkind[j]);
                        break;
                    case 10:
                        Console.WriteLine("Ten of " + Cardkind[j]);
                        break;
                    case 11:
                        Console.WriteLine("Jack of " + Cardkind[j]);
                        break;
                    case 12:
                        Console.WriteLine("Queen of " + Cardkind[j]);
                        break;
                    case 13:
                        Console.WriteLine("King of " + Cardkind[j]);
                        break;
                }
            }
        }
       
    }
}
