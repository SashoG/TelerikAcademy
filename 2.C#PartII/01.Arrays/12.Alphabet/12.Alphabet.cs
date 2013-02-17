using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.


class Program
{
    static void Main(string[] args)
    {
        char[] Letter = new char[26];
        for (int index = 0; index < 26; index++)
        {
            Letter[index] = (char)(index + 65);
        }
        Console.Write("Enter word: ");
        string Word = Console.ReadLine();

        for (int index1 = 0; index1 < Word.Length; index1++)
        {
            for (int index2 = 0; index2 < 26; index2++)
            {
                if (Word[index1].Equals(Letter[index2]))
                {
                    Console.WriteLine("{0} = {1}", Word[index1], Letter[index2]);
                }
            }
        }
    }
}
