using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MissCat2011
{
    class MissCat2011
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int Vote = new int();
            int[] catNumberScore = new int[11];
            for (int i = 0; i < N; i++)
            {
                Vote = int.Parse(Console.ReadLine());
                switch (Vote)
                {
                    case 1:
                        {
                            catNumberScore[1]++;
                        }
                        break;
                    case 2:
                        {
                            catNumberScore[2]++;
                        }
                        break;
                    case 3:
                        {
                            catNumberScore[3]++;
                        }
                        break;
                    case 4:
                        {
                            catNumberScore[4]++;
                        }
                        break;
                    case 5:
                        {
                            catNumberScore[5]++;
                        }
                        break;
                    case 6:
                        {
                            catNumberScore[6]++;
                        }
                        break;
                    case 7:
                        {
                            catNumberScore[7]++;
                        }
                        break;
                    case 8:
                        {
                            catNumberScore[8]++;
                        }
                        break;
                    case 9:
                        {
                            catNumberScore[9]++;
                        }
                        break;
                    case 10:
                        {
                            catNumberScore[10]++;
                        }
                        break;
                }
            }
            int maxValue = new int();
            int winner = new int();
            for (int i = 1; i <= 10; i++)
            {
                if (maxValue < catNumberScore[i])
                {
                    maxValue = catNumberScore[i];
                    winner = i;
                }
            }
            Console.WriteLine(winner);
        }
    }
}
