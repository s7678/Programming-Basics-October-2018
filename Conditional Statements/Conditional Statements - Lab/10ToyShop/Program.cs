using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursion = double.Parse(Console.ReadLine());
            int puzzel = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int truks = int.Parse(Console.ReadLine());
            double disscountPrice = 0;
            double rentPrice = 0;
            

            int allToys = puzzel + dolls + bears + minions + truks;

            double puzzelPrice = puzzel * 2.60;
            double dollsPrice = dolls * 3;
            double bearsPrice = bears * 4.10;
            double minionsPrice = minions * 8.20;
            double truksPrice = truks * 2;

            

            double totalToysPrice = puzzelPrice + dollsPrice + bearsPrice + minionsPrice + truksPrice;

            if (allToys>=50)
            {
                disscountPrice = totalToysPrice * 0.25;
            }

            double sumAfterDisccount = totalToysPrice - disscountPrice;
            double finalSum = sumAfterDisccount * 0.90;

            if (finalSum>=excursion)
            {
                Console.WriteLine($"Yes! {finalSum-excursion:f2} lv left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! {excursion-finalSum:f2} lv needed.");
            }
       


            







        }
    }
}
