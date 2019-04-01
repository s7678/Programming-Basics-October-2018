using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartment = 0;




            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights <= 13)
                {
                    priceStudio = 50 * 0.95;
                }

                else if (nights > 14)
                {
                    priceStudio = 50 * 0.70;
                    priceApartment = 65 * 0.90;

                }

                else
                {
                    priceStudio = 50;
                    priceApartment = 65;
                }

            }

            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    priceApartment = 68.70 * 0.90;
                    priceStudio = 75.20 * 0.80;
                }
                else
                {
                    priceStudio = 75.20;
                    priceApartment = 68.70;
                }

            }

            else if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    priceApartment = 77 * 0.90;
                    priceStudio = 76;
                }
                else
                {
                    priceStudio = 76;
                    priceApartment = 77;
                }

            }

            double totalStudio = priceStudio * nights;
            double totalApartment = priceApartment * nights;

            Console.WriteLine("Apartment: {0} lv.", ($"{totalApartment:f2}"));

            Console.WriteLine("Studio: {0} lv.", ($"{totalStudio:f2}"));




        }
    }
}
