﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Falling_Rocks
{
    class Program
    {
        struct Position
        {
            public int X, Y;
            public Position(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        private static List<Position> MakeArrayForRocks()
        {
            Random randomGenerator = new Random(DateTime.Now.Millisecond);
            List<Position> rocks = new List<Position>();
            for (int i = 0; i < randomGenerator.Next(2, 7); i++)
            {
                rocks.Add(new Position(
                    randomGenerator.Next(1, Console.WindowWidth - 1),
                    randomGenerator.Next(1, Console.WindowHeight - 13)));
            }

            return rocks;
        }

        private static void PrintRock(List<Position> rocks, string rock)
        {
            Random randomGenerator = new Random(DateTime.Now.Millisecond);   
            ConsoleColor[] colors =
            {
                ConsoleColor.Yellow,
                ConsoleColor.DarkGreen,
                ConsoleColor.Cyan,
                ConsoleColor.Green,
                ConsoleColor.Blue,
                ConsoleColor.Magenta,
                ConsoleColor.White,
                ConsoleColor.Red,
                ConsoleColor.Gray
            };

            for (int i = 0; i < rocks.Count; i++)
            {
                Console.SetCursorPosition(rocks[i].X, rocks[i].Y);
                Console.ForegroundColor = colors[randomGenerator.Next(0, colors.Length)];
                Console.Write(rock);
            }
        }

        private static void MoveRock(ref List<Position> rocks, string rock)
        {
            Random randomGenerator = new Random(DateTime.Now.Millisecond);   
            ConsoleColor[] colors =
            {
                ConsoleColor.Yellow,
                ConsoleColor.DarkGreen,
                ConsoleColor.Cyan,
                ConsoleColor.Green,
                ConsoleColor.Blue,
                ConsoleColor.Magenta,
                ConsoleColor.White,
                ConsoleColor.Red,
                ConsoleColor.Gray
            };
            List<Position> newRocks = new List<Position>();
            foreach (var currentRock in rocks)
            {
                Console.SetCursorPosition(currentRock.X, currentRock.Y);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(" ");
                Console.SetCursorPosition(currentRock.X, (currentRock.Y + 1));
                newRocks.Add(new Position(currentRock.X, currentRock.Y + 1));
                Console.ForegroundColor = colors[randomGenerator.Next(0, colors.Length)];
                Console.Write(rock);
            }
            rocks = newRocks;
        }

        private static void MoveDwarf(ref Position dwarf, ConsoleKeyInfo pressedKey)
        {
            if (pressedKey.Key == ConsoleKey.RightArrow)
            {
                if (dwarf.X != (Console.WindowWidth - 3))
                {
                    Console.SetCursorPosition(dwarf.X, dwarf.Y);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                    Console.SetCursorPosition(dwarf.X + 1, dwarf.Y);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                    Console.SetCursorPosition(dwarf.X - 1, dwarf.Y);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                    Console.SetCursorPosition((dwarf.X += 1), dwarf.Y);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("0");
                    Console.SetCursorPosition(dwarf.X + 1, dwarf.Y);
                    Console.Write(")");
                    Console.SetCursorPosition(dwarf.X - 1, dwarf.Y);
                    Console.Write("(");
                }
                else
                {
                    Console.SetCursorPosition(dwarf.X, (dwarf.Y - 1));
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                    Console.SetCursorPosition(dwarf.X, dwarf.Y);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("0");
                    Console.SetCursorPosition(dwarf.X + 1, dwarf.Y);
                    Console.Write(")");
                    Console.SetCursorPosition(dwarf.X - 1, dwarf.Y);
                    Console.Write("(");
                }
            }
            else if (pressedKey.Key == ConsoleKey.LeftArrow)
            {
                if (dwarf.X != (Console.WindowWidth - 79))
                {
                    Console.SetCursorPosition(dwarf.X, dwarf.Y);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                    Console.SetCursorPosition(dwarf.X + 1, dwarf.Y);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                    Console.SetCursorPosition(dwarf.X - 1, dwarf.Y);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                    Console.SetCursorPosition((dwarf.X -= 1), dwarf.Y);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("0");
                    Console.SetCursorPosition(dwarf.X + 1, dwarf.Y);
                    Console.Write(")");
                    Console.SetCursorPosition(dwarf.X - 1, dwarf.Y);
                    Console.Write("(");
                }
                else
                {
                    Console.SetCursorPosition(dwarf.X, dwarf.Y);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("0");
                    Console.SetCursorPosition(dwarf.X + 1, dwarf.Y);
                    Console.Write(")");
                    Console.SetCursorPosition(dwarf.X - 1, dwarf.Y);
                    Console.Write("(");
                }
            }
        }

        private static bool Check(ref List<Position> rocks, Position dwarf, DateTime startingTime, string rockSymbol)
        {
            Random randomGenerator = new Random(DateTime.Now.Millisecond); 
            ConsoleColor[] colors =
            {
                ConsoleColor.Yellow,
                ConsoleColor.DarkGreen,
                ConsoleColor.Cyan,
                ConsoleColor.Green,
                ConsoleColor.Blue,
                ConsoleColor.Magenta,
                ConsoleColor.White,
                ConsoleColor.Red,
                ConsoleColor.Gray
            };
            List<Position> newRocks = new List<Position>();

            foreach (var rock in rocks)
            {
                if (rock.Y > (Console.WindowHeight - 2))
                {
                    if (dwarf.X == rock.X || (dwarf.X - 1) == rock.X || (dwarf.X + 1) == rock.X)
                    {
                        Console.SetCursorPosition(0, 0);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Game over!!!");
                        Console.WriteLine("You have been alive for : " + (DateTime.Now - startingTime) + " seconds");
                        Console.ReadLine();
                        return true;
                    }
                    else
                    {
                        Console.SetCursorPosition(rock.X, rock.Y);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                        Position newRock = new Position(randomGenerator.Next(1, Console.WindowWidth - 1), randomGenerator.Next(1, Console.WindowHeight - 13));
                        newRocks.Add(newRock);
                        Console.SetCursorPosition(newRock.X, (newRock.Y));
                        Console.ForegroundColor = colors[randomGenerator.Next(0, colors.Length)];
                        Console.Write(rockSymbol);
                    }
                }
                else
                {
                    newRocks.Add(rock);
                }
            }
            rocks = newRocks;
            return false;
        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight;
            DateTime startingTime = DateTime.Now;
            double sleepTime = 50;

            Position dwarf = new Position(39, 24);
            Console.SetCursorPosition(dwarf.X, dwarf.Y);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("0");
            Console.SetCursorPosition(dwarf.X + 1, dwarf.Y);
            Console.Write(")");
            Console.SetCursorPosition(dwarf.X - 1, dwarf.Y);
            Console.Write("(");

            List<Position> plusRocks = MakeArrayForRocks();
            PrintRock(plusRocks, "+");
            List<Position> upperRocks = MakeArrayForRocks();
            PrintRock(upperRocks, "^");
            List<Position> maimunRocks = MakeArrayForRocks();
            PrintRock(maimunRocks, "@");
            List<Position> multyRocks = MakeArrayForRocks();
            PrintRock(multyRocks, "*");
            List<Position> andRocks = MakeArrayForRocks();
            PrintRock(andRocks, "&");
            List<Position> procentRocks = MakeArrayForRocks();
            PrintRock(procentRocks, "%");
            List<Position> moneyRocks = MakeArrayForRocks();
            PrintRock(moneyRocks, "$");
            List<Position> sharpRocks = MakeArrayForRocks();
            PrintRock(sharpRocks, "#");
            List<Position> minusRocks = MakeArrayForRocks();
            PrintRock(minusRocks, "-");
            List<Position> exclamationRocks = MakeArrayForRocks();
            PrintRock(exclamationRocks, "!");
            List<Position> dotRocks = MakeArrayForRocks();
            PrintRock(dotRocks, ".");
            List<Position> dotSlashRocks = MakeArrayForRocks();
            PrintRock(dotSlashRocks, ";");

            int speedMeter = 1;
            Console.ReadKey();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey();
                    MoveDwarf(ref dwarf, pressedKey);
                }
                if (speedMeter % 3 == 0) 
                {
                    MoveRock(ref plusRocks, "+");
                    if (Check(ref plusRocks, dwarf, startingTime, "+"))
                    {
                        return;
                    }

                    MoveRock(ref upperRocks, "^");
                    if (Check(ref upperRocks, dwarf, startingTime, "^"))
                    {
                        return;
                    }

                    MoveRock(ref maimunRocks, "@");
                    if (Check(ref maimunRocks, dwarf, startingTime, "@"))
                    {
                        return;
                    }

                    MoveRock(ref multyRocks, "*");
                    if (Check(ref multyRocks, dwarf, startingTime, "*"))
                    {
                        return;
                    }

                    MoveRock(ref andRocks, "&");
                    if (Check(ref andRocks, dwarf, startingTime, "&"))
                    {
                        return;
                    }

                    MoveRock(ref procentRocks, "%");
                    if (Check(ref procentRocks, dwarf, startingTime, "%"))
                    {
                        return;
                    }

                    MoveRock(ref moneyRocks, "$");
                    if (Check(ref moneyRocks, dwarf, startingTime, "$"))
                    {
                        return;
                    }

                    MoveRock(ref sharpRocks, "#");
                    if (Check(ref sharpRocks, dwarf, startingTime, "#"))
                    {
                        return;
                    }

                    MoveRock(ref minusRocks, "-");
                    if (Check(ref minusRocks, dwarf, startingTime, "-"))
                    {
                        return;
                    }

                    MoveRock(ref exclamationRocks, "!");
                    if (Check(ref exclamationRocks, dwarf, startingTime, "!"))
                    {
                        return;
                    }

                    MoveRock(ref dotRocks, ".");
                    if (Check(ref dotRocks, dwarf, startingTime, "."))
                    {
                        return;
                    }

                    MoveRock(ref dotSlashRocks, ";");
                    if (Check(ref dotSlashRocks, dwarf, startingTime, ";"))
                    {
                        return;
                    }
                }

                speedMeter++;
                Thread.Sleep((int)sleepTime);
                sleepTime -= 0.02;
            }
        }
    }
}