using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SequencesInMAtrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] givenMatrix = new string[,]
            {
                {"ha","fifi", "ho", "xx"},
                {"fo", "ha", "hi", "xx"},
                {"xxx", "ho","ha", "xx"},
                {"xxx", "ho","ha", "xx"},

            };
            int SeqNum = 1;
            int longestSeq = 0;
            string longestString = "";


            for (int row = 0; row < givenMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < givenMatrix.GetLength(1); col++)
                {
                    int colStore = col;
                    int rowStore = row;
                    while ((col < givenMatrix.GetLength(1) - 1) && givenMatrix[row, col].Equals(givenMatrix[row, col + 1], StringComparison.Ordinal))
                    {
                        col++;
                        SeqNum++;
                        if (SeqNum > longestSeq)
                        {
                           longestSeq = SeqNum;
                           longestString = givenMatrix[row,col];
                        }
                    }
                    col = colStore;
                    SeqNum = 1;
                    while ((row < givenMatrix.GetLength(0) - 1) && givenMatrix[row, col].Equals(givenMatrix[row + 1, col], StringComparison.Ordinal))
                    {
                        row++;
                        SeqNum++;
                        if (SeqNum > longestSeq)
                        {
                            longestSeq = SeqNum;
                            longestString = givenMatrix[row,col];
                        }
                    }
                    row = rowStore;
                    SeqNum = 1;
                    while ((row < givenMatrix.GetLength(0) - 1) && (col < givenMatrix.GetLength(1) - 1) && givenMatrix[row, col].Equals(givenMatrix[row + 1, col + 1], StringComparison.Ordinal))
                    {
                        row++;
                        col++;
                        SeqNum++;
                        if (SeqNum > longestSeq)
                        {
                            longestSeq = SeqNum;
                            longestString = givenMatrix[row,col];

                        }
                    }
                    row = rowStore;
                    col = colStore;
                    SeqNum = 1;
                }
            }
            for (int i = 0; i < longestSeq; i++)
            {
                Console.Write("{0} ",longestString);
            }
            Console.WriteLine();



        }
    }
}
