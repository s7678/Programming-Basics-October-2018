using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Dance_Hall_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobe = double.Parse(Console.ReadLine());
            double oneDancer = 7000 + 40;

            double zalaSize = (lenght * 100) * (width * 100);
            double wardrobeSize = (wardrobe * 100) * (wardrobe * 100);

            double benchSize = zalaSize / 10;

            double freeSpace = zalaSize - wardrobeSize - benchSize;

            double spaceForDancers = freeSpace / oneDancer;
            Console.WriteLine(Math.Floor(spaceForDancers));


        }
    }
}
