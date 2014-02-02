using System;

class Subset0
{
    static void Main(string[] args)
    {
        Console.Write("Enter variable 1:");
        string str1 = Console.ReadLine();
        int var1 = int.Parse(str1);
        Console.Write("Enter variable 2:");
        string str2 = Console.ReadLine();
        int var2 = int.Parse(str2);
        Console.Write("Enter variable 3:");
        string str3 = Console.ReadLine();
        int var3 = int.Parse(str3);
        Console.Write("Enter variable 4:");
        string str4 = Console.ReadLine();
        int var4 = int.Parse(str4);
        Console.Write("Enter variable 5:");
        string str5 = Console.ReadLine();
        int var5 = int.Parse(str5);
        bool flag = true;
        int exit = 1;
        while (flag & exit<=2)
	    {
            if (var1==0)
            {
                Console.WriteLine("Subset with sum 0 is: {0}", var1);
                flag = false;
            }
            if (var2 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0}", var2);
                flag = false;
            }
            if (var3 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0}", var3);
                flag = false;
            }
            if (var4 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0}", var4);
                flag = false;
            }
            if (var5 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0}", var5);
                flag = false;
            }
            if (var1 + var2 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1}", var1, var2);
                flag = false;
            }
            if (var1 + var3 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1}", var1, var3);
                flag = false;
            }
            if (var1 + var4 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1}", var1, var4);
                flag = false;
            }
            if (var1 + var5 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1}", var1, var5);
                flag = false;
            }
            if (var2 + var3 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1}", var2, var3);
                flag = false;
            }
            if (var2 + var4 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1}", var2, var4);
                flag = false;
            }
            if (var2 + var5 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1}", var2, var5);
                flag = false;
            }
            if (var3 + var4 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1}", var3, var4);
                flag = false;
            }
            if (var3 + var5 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1}", var3, var5);
                flag = false;
            }
            if (var4 + var5 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1}", var4, var5);
                flag = false;
            }
            if (var1 + var2 + var3 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2}", var1, var2, var3);
                flag = false;
            }
            if (var1 + var2 + var4 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2}", var1, var2, var4);
                flag = false;
            }
            if (var1 + var2 + var5 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2}", var1, var2, var5);
                flag = false;
            }
            if (var1 + var3 + var4 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2}", var1, var3, var4);
                flag = false;
            }
            if (var1 + var3 + var5 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2}", var1, var3, var5);
                flag = false;
            }
            if (var1 + var4 + var5 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2}", var1, var4, var5);
                flag = false;
            }
            if (var2 + var3 + var4 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2}", var2, var3, var4);
                flag = false;
            }
            if (var2 + var3 + var5 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2}", var2, var3, var5);
                flag = false;
            }
            if (var2 + var4 + var5 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2}", var2, var4, var5);
                flag = false;
            }
            if (var3 + var4 + var5 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2}", var3, var4, var5);
                flag = false;
            }
            if (var1 + var2 + var3 + var4 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2},{3}", var1, var2, var3, var4);
                flag = false;
            }
            if (var1 + var2 + var3 + var5 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2},{3}", var1, var2, var3, var5);
                flag = false;
            }
            if (var2 + var3 + var4 + var5 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2},{3}", var2, var3, var4, var5);
                flag = false;
            }
            if (var4 + var5 + var2 + var1 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2},{3}", var4, var5, var2, var1);
                flag = false;
            }
            if (var4 + var5 + var3 + var1 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2},{3}", var4, var5, var3, var1);
                flag = false;
            }
            if (var1 + var2 + var3 + var4 + var5 == 0)
            {
                Console.WriteLine("Subset with sum 0 is: {0},{1},{2},{3},{4}", var1, var2, var3, var4, var5);
                flag = false;
            }
            if (exit==2)
            {
                Console.WriteLine("No such subset");
            }
            exit++;
	    }
    }
}