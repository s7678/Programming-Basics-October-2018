using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05TrapeziodArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double trapeziodArea = ((b1 + b2) * h )/ 2;

            Console.WriteLine(trapeziodArea);

        }
    }
}
