using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());

            double radToDeg = (rad * 180) / Math.PI;

            Console.WriteLine(Math.Round(radToDeg));
        }
    }
}
