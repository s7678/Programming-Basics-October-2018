using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07AlcoholMarket
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

            double rakiaPrice = (whiskyPrice / 2);

            double whisky = whiskyPrice * quantityWhisky;
            double rakia =  rakiaPrice* quantityRakia;
            double beer = (rakiaPrice - (rakiaPrice * 0.80)) * quantityBeer;
            double wine = (rakiaPrice - (rakiaPrice * 0.40)) * quantityWine;

            double total = whisky + rakia + beer + wine;

            Console.WriteLine($"{total:f2}");
        }
    }
}
