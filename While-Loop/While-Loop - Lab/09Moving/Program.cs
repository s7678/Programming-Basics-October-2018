using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            int volumeFreeSpace = width * lenght * high;

            string word = Console.ReadLine();
            int boxes = 0;




            while (word != "Done")
            {
                
                boxes += int.Parse(word);

                if (boxes >= volumeFreeSpace)
                {
                    double neededSpace = Math.Abs(volumeFreeSpace - boxes);
                    Console.WriteLine($"No more free space! You need {neededSpace} Cubic meters more.");
                    break;

                }
                word = Console.ReadLine();


            }

            if (word == "Done")
            {

                Console.WriteLine($"{volumeFreeSpace - boxes} Cubic meters left.");


            }

        }
    }
}
