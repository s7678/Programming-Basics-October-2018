
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double high = double.Parse(Console.ReadLine());

            double area = (side * high) / 2;

            Console.WriteLine(area);
        }
    }
}
