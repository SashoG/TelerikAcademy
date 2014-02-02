using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle
{
    class Triangle
    {
        private static double SurfaceTriangle1(double side1, double altitude)
        {
            double surface = 0.5d * side1 * altitude;
            return surface;
        }
        
        private static double SurfaceTriangle2(double side1, double side2, double side3)
        {
            double s = (side1+side2+side3)/2d;
            double surface = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            return surface;
        }
       
        private static double SurfaceTriangle3(double side1, double side2, double angle) //angle is in rad
        {
            double surface = side1*side2*Math.Sin(angle)/2;
            return surface;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(SurfaceTriangle1(10,10));
            Console.WriteLine(SurfaceTriangle2(10,10,10));
            Console.WriteLine(SurfaceTriangle3(10,10,2.4));
        }
    }
}
