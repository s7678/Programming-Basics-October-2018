using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double rectangelArea = (lenght * 100) * (width * 100);
            double wardrobeArea = (wardrobeSide * 100) * (wardrobeSide * 100);
            double benchArea = rectangelArea / 10;

            double dancer = 40 + 7000;

            double totalSpace = rectangelArea - wardrobeArea - benchArea;
            double countOfDancers = totalSpace / dancer;
            Console.WriteLine(Math.Floor(countOfDancers));
        }
    }
}
