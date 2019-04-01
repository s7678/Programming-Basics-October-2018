using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Alcohol_Market_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskyPrice = double.Parse(Console.ReadLine());
            double quantityBeer = double.Parse(Console.ReadLine());
            double quantityWine = double.Parse(Console.ReadLine());
            double quantityRakia = double.Parse(Console.ReadLine());
            double quantityWhisky = double.Parse(Console.ReadLine());


            double rakiaPrice = whiskyPrice / 2.00;
            double beerPrice = rakiaPrice - (rakiaPrice * 0.80);
            double winePrice = rakiaPrice - (rakiaPrice * 0.40);

            double whisky = whiskyPrice * quantityWhisky;
            double beer = beerPrice * quantityBeer;
            double wine = winePrice * quantityWine;
            double rakia = rakiaPrice * quantityRakia;

            double total = whisky + beer + wine + rakia;

            Console.WriteLine($"{total:f2}");

        }
    }
}
