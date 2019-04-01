using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");

                if (season == "summer")
                {
                    price = budget * 0.30;

                    Console.WriteLine("Camp - " + ($"{price:f2}"));
                }

                else if (season == "winter")
                {
                    price = budget * 0.70;
                    Console.WriteLine("Hotel - " + ($"{price:f2}"));
                }
            }


            if (budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");

                if (season == "summer")
                {
                    price = budget * 0.40;
                    Console.WriteLine("Camp - " + ($"{price:f2}"));

                }

                else if (season == "winter")
                {
                    price = budget * 0.80;
                    Console.WriteLine("Hotel - " + ($"{price:f2}"));
                }
            }

            if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                price = budget * 0.90;
                Console.WriteLine("Hotel - " + ($"{price:f2}"));
            }
        }
    }
}
