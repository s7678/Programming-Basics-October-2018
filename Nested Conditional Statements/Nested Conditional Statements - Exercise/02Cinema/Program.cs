using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double fullHall = 0;
            double price = 0;

            if (projection == "Premiere")
            {
                price = 12.00;
            }

            else if (projection == "Normal")
            {
                price = 7.50;
            }

            else if (projection == "Discount")
            {
                price = 5.00;
            }


            fullHall = price * rows * colums;

            Console.WriteLine($"{fullHall:f2}");
        }
    }
}
