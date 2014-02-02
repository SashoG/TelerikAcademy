using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ShipDamage
{
    class ShipDamage
    {
        static void Main(string[] args)
        {
            int SX1 = int.Parse(Console.ReadLine()),
                SY1 = int.Parse(Console.ReadLine()),
                SX2 = int.Parse(Console.ReadLine()),
                SY2 = int.Parse(Console.ReadLine()),
                H = int.Parse(Console.ReadLine()),
                CX1 = int.Parse(Console.ReadLine()),
                CY1 = H - int.Parse(Console.ReadLine()),
                CX2 = int.Parse(Console.ReadLine()),
                CY2 = H - int.Parse(Console.ReadLine()),
                CX3 = int.Parse(Console.ReadLine()),
                CY3 = H - int.Parse(Console.ReadLine());
            int damage = new int();
            if ((CX1 == SX1 && CY1 == SY1) || (CX1 == SX2 && CY1 == SY2) || (CX1 == SX1 && CY1 == SY2) || (CX1 == SX2 && CY1 == SY1))
            {
                damage += 25;
            }
            if ((CX2 == SX1 && CY2 == SY1) || (CX2 == SX2 && CY2 == SY2) || (CX2 == SX1 && CY2 == SY2) || (CX2 == SX2 && CY2 == SY1))
            {
                damage += 25;
            }
            if ((CX3 == SX1 && CY3 == SY1) || (CX3 == SX2 && CY3 == SY2) || (CX3 == SX1 && CY3 == SY2) || (CX3 == SX2 && CY3 == SY1))
            {
                damage += 25;
            }
            if ((CX1 < Math.Max(SX1, SX2)) && (CX1 > Math.Min(SX1, SX2))&&(CY1>Math.Min(SY1,SY2))&& (CY1<Math.Max(SY1,SY2)))
            {
                damage += 100;
            }
            if ((CX2 < Math.Max(SX1, SX2)) && (CX2 > Math.Min(SX1, SX2)) && (CY2 > Math.Min(SY1, SY2)) && (CY2 < Math.Max(SY1, SY2)))
            {
                damage += 100;
            }
            if ((CX3 < Math.Max(SX1, SX2)) && (CX3 > Math.Min(SX1, SX2)) && (CY3 > Math.Min(SY1, SY2)) && (CY3 < Math.Max(SY1, SY2)))
            {
                damage += 100;
            }
            if ((CX1 == SX1 || CX1 == SX2) && CY1 < Math.Max(SY1, SY2) && CY1 > Math.Min(SY1, SY2))
            {
                damage += 50;
            }
            if ((CX2 == SX1 || CX2 == SX2) && CY2 < Math.Max(SY1, SY2) && CY2 > Math.Min(SY1, SY2))
            {
                damage += 50;
            }
            if ((CX3 == SX1 || CX3 == SX2) && CY3 < Math.Max(SY1, SY2) && CY3 > Math.Min(SY1, SY2))
            {
                damage += 50;
            }
            if ((CY1 == SY1 || CY1 == SY2) && CX1 > Math.Min(SX1, SX2) && CX1 < Math.Max(SX1, SX2))
            {
                damage += 50;
            }
            if ((CY2 == SY1 || CY2 == SY2) && CX2 > Math.Min(SX1, SX2) && CX2 < Math.Max(SX1, SX2))
            {
                damage += 50;
            }
            if ((CY3 == SY1 || CY3 == SY2) && CX3 > Math.Min(SX1, SX2) && CX3 < Math.Max(SX1, SX2))
            {
                damage += 50;
            }
            Console.WriteLine(damage + "%");
        }
    }
}
