using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Charity_Campaign_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int campaign = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int panckakes = int.Parse(Console.ReadLine());

            double dept = 1.00 / 8.00;

            double cakesPrice = cakes * 45.00;
            double wafflesPrice = waffles * 5.80;
            double panckakesPrice = panckakes * 3.20;

            double totalSweets = cakesPrice + wafflesPrice + panckakesPrice;

            double totalCampaign = campaign * (bakers * totalSweets);
            double totalMoney = totalCampaign - (totalCampaign * dept);
            Console.WriteLine($"{totalMoney:f2}");



        }
    }
}
