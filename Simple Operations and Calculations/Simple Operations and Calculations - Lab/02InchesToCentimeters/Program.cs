using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());

            double inchesToCentimeters = inches * 2.54;

            Console.WriteLine(inchesToCentimeters);
        }
    }
}
