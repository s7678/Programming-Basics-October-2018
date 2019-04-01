using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangelArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());

            int area = sideA * sideB;

            Console.WriteLine(area);
        }
    }
}
