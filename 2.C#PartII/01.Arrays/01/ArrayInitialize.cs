﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //Write a program that allocates array of 20 integers and initializes 
    //each element by its index multiplied by 5. Print the obtained array on the console.

    
    static void Main(string[] args)
    {
        int[] MyArray = new int[20];
        for (int index = 0; index < 20; index++)
        {
            MyArray[index] = index * 5;
            Console.WriteLine(MyArray[index]);
        }
    }
}
