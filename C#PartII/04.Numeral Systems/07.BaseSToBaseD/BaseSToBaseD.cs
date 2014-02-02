using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{

    static char GetChar(int i)
    {
        if (i >= 10)
        {
            return (char)('A' + i - 10);
        }
        else
        {
            return (char)('0' + i);
        }
    }

    static int GetNumber(string s, int i)
    {
        if (s[i] >= 'A')
        {
            return s[i] - 'A' + 10;
        }
        else
        {
            return s[i] - '0';
        }
    }

    static string Base10ToBaseD(int d, int D)
    {
        string h = String.Empty;
        while (d != 0) 
        {
            h += GetChar(d % D);
            d /= D;
        }
        return h;
    }

    static int BaseSToBase10(string h, int S)
    {
        int d = 0;

        for (int i = h.Length - 1, p = 1; i >= 0; i--, p *= S)
        {
            d += GetNumber(h, i) * p;
        }
        return d;
    }

    static string BaseSToBaseD(string n, int x, int y)
    {
        return Base10ToBaseD(BaseSToBase10(n, x), y);
    }
   
    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    static void Main()
    {

        Console.Write("Enter numeral system S:");
        int baseS = int.Parse(Console.ReadLine());
        Console.Write("Enter number in numerl system S:");
        string str = Console.ReadLine();
        Console.Write("Enter numeral system for conversion D:");
        int baseD = int.Parse(Console.ReadLine());

        Console.WriteLine("Number is numeral system based on {0} is {1}",baseD, ReverseString(BaseSToBaseD(str, baseS, baseD)));
    }
}
