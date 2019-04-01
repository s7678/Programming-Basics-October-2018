using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string comment = Console.ReadLine();

            int nights = days - 1;
            double totalNights = 0;

            switch (type)
            {
                case "room for one person": totalNights = nights * 18; break;
                case "apartment": totalNights = nights * 25.00; break;
                case "president apartment": totalNights = nights * 35.00; break;

                default:
                    break;
            }

            double priceWithDiscount = 0;

            if (type == "apartment")
            {
                if (nights < 10)
                {
                    priceWithDiscount = totalNights * 0.70;
                }

                else if (nights < 15)
                {
                    priceWithDiscount = totalNights * 0.65;
                }

                else if (nights >= 15)
                {
                    priceWithDiscount = totalNights * 0.50;
                }
            }


            else if (type == "president apartment")
            {
                if (nights < 10)
                {
                    priceWithDiscount = totalNights * 0.90;
                }

                else if (nights < 15)
                {
                    priceWithDiscount = totalNights * 0.85;
                }

                else if (nights >= 15)
                {
                    priceWithDiscount = totalNights * 0.80;
                }

            }

            else
            {
                priceWithDiscount = totalNights;
            }


            double finalPrice = 0;

            if (comment == "positive")
            {
                finalPrice = (priceWithDiscount * 0.25) + priceWithDiscount;
            }

            else if (comment == "negative")
            {
                finalPrice = Math.Abs((priceWithDiscount * 0.10) - priceWithDiscount);
            }




            Console.WriteLine($"{finalPrice:f2}");



        }
    }
}
