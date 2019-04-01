using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int campaign = int.Parse(Console.ReadLine());
            int backers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double priceCakes = cakes * 45;
            double priceWaffles = waffles * 5.80;
            double pricePancakes = pancakes * 3.20;

            double totalMakeForAllBakers = backers * (priceCakes + pricePancakes + priceWaffles)*campaign;
            
            double earnMoneyFromTheCampaign = totalMakeForAllBakers - (0.125 * totalMakeForAllBakers);
            Console.WriteLine($"{earnMoneyFromTheCampaign:f2}");
      

        }
    }
}
