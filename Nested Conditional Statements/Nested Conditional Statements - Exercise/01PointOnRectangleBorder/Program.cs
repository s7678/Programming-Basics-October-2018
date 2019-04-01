using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isOnXSide = x == x1 && y >= y1 && y <= y2;
            bool isOnOtheXSide = x == x2 && y >= y1 && y <= y2;

            bool isOnYSide = y == y1 && x >= x1 && x <= x2;
            bool isOnOtheYSide = y == y2 && x >= x1 && x <= x2;


            if (isOnXSide || isOnYSide||isOnOtheXSide||isOnOtheYSide)
            {
                Console.WriteLine("Border");
            }

            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
