using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int quantityFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double discount = 0;
            double price = 0;
            double totalMoney = 0;
            
            double expense = 0;



            if (flower == "Roses")
            {
                price = 5;
                if (quantityFlowers > 80)
                {
                    discount = 0.90;
                    totalMoney = quantityFlowers * price * discount;
                }

                else
                {
                    totalMoney = quantityFlowers * price;
                }

            }


            else if (flower == "Dahlias")
            {
                price = 3.80;
                if (quantityFlowers > 90)
                {
                    discount = 0.85;
                    totalMoney = quantityFlowers * price * discount;
                }

                else
                {
                    totalMoney = quantityFlowers * price;
                }

            }

            else if (flower == "Tulips")
            {
                price = 2.80;
                if (quantityFlowers > 80)
                {
                    discount = 0.85;
                    totalMoney = quantityFlowers * price * discount;
                }

                else
                {
                    totalMoney = quantityFlowers * price;
                }

            }

            else if (flower == "Narcissus")
            {
                price = 3;
                if (quantityFlowers < 120)
                {
                    expense = 0.15;
                    double totalExpence = quantityFlowers * price * expense;
                     totalMoney = (quantityFlowers * price) + totalExpence;

                }

                else
                {
                    totalMoney = quantityFlowers * price;
                }

            }

            else if (flower == "Gladiolus")
            {
                price = 2.50;
                if (quantityFlowers < 80)
                {
                    expense = 0.20;
                   double totalExpence = quantityFlowers * price * expense;
                    totalMoney = (quantityFlowers * price) + totalExpence;

                }

                else
                {
                    totalMoney = quantityFlowers * price;
                }

            }

            double money = budget - totalMoney;
            double neededMoney = totalMoney - budget;


            if (totalMoney <= budget)
            {
                Console.WriteLine("Hey, you have a great garden with " + quantityFlowers + " " + flower + " and " + ($"{money:f2}") + " leva left.");

            }

            else
            {
                Console.WriteLine("Not enough money, you need " + ($"{neededMoney:f2}") + " leva more.");

            }
        }
    }
}
