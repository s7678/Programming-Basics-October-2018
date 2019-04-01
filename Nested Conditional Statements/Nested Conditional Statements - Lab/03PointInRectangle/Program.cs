using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PointInRectangle
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

            if (x1 <= x2 && x2 >= x1 && y1 <= y2 && y2 >= y1 && x >= x1 && y >= y1 && x <= x2 && y <= y2)
            {
                Console.WriteLine("Inside");
            }

            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
