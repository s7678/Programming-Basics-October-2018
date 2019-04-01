using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherMan = int.Parse(Console.ReadLine());

            double rentForBoat = 0;
            double discount = 0;
            double priceForAllFisherMans = 0;


            if (season == "Spring")
            {
                rentForBoat = 3000;
            }

            else if (season == "Summer" || season == "Autumn")
            {
                rentForBoat = 4200;
            }

            else if (season == "Winter")
            {
                rentForBoat = 2600;
            }

            if (fisherMan <= 6)
            {
                discount = 0.90;
            }

            else if (fisherMan >= 7 && fisherMan <= 11)
            {
                discount = 0.85;
            }


            else if (fisherMan > 12)
            {
                discount = 0.75;
            }



            priceForAllFisherMans = rentForBoat * discount;

            if (fisherMan % 2 == 0)
            {
                if (season == "Spring" || season == "Summer" || season == "Winter")
                {
                    priceForAllFisherMans = priceForAllFisherMans * 0.95;

                }

                
                
            }

            double neededMoney = Math.Abs(priceForAllFisherMans - budget);
            double leftMoney = Math.Abs(budget - priceForAllFisherMans);

            if (budget >= priceForAllFisherMans)
            {
                Console.WriteLine("Yes! You have {0} leva left.", ($"{leftMoney:f2}"));
            }

            else
            {
                Console.WriteLine("Not enough money! You need {0} leva.", ($"{neededMoney:f2}"));
            }






        }
    }
}
