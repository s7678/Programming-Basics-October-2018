using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());

            double percent = double.Parse(Console.ReadLine());

            double volumeParalelepipet = lenght * weight * high;
            double volumeInLiters = volumeParalelepipet / 1000;
            
            double percentForAquarium = percent * 0.01;

            double volume = volumeInLiters * (1 - percentForAquarium);
            Console.WriteLine($"{volume:f3}");
        }
    }
}
