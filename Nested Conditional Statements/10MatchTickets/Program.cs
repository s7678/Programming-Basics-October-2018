using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleInTheGroup = int.Parse(Console.ReadLine());
            double priceTickets = 0;


            double moneyFromTheBudgetWithoutTransport = 0;

            if (category == "VIP")
            {
                priceTickets = 499.99 * peopleInTheGroup;
            }

            else if (category == "Normal")
            {
                priceTickets = 249.99 * peopleInTheGroup;
            }



            if (peopleInTheGroup >= 1 && peopleInTheGroup <= 4)
            {
                moneyFromTheBudgetWithoutTransport = budget * 0.25;
            }

            else if (peopleInTheGroup >= 5 && peopleInTheGroup <= 9)
            {
                moneyFromTheBudgetWithoutTransport = budget * 0.40;
            }

            else if (peopleInTheGroup >= 10 && peopleInTheGroup <= 24)
            {
                moneyFromTheBudgetWithoutTransport = budget * 0.50;
            }

            else if (peopleInTheGroup >= 25 && peopleInTheGroup <= 49)
            {
                moneyFromTheBudgetWithoutTransport = budget * 0.60;
            }
            else if (peopleInTheGroup >= 50)
            {
                moneyFromTheBudgetWithoutTransport = budget * 0.75;
            }


            double money = moneyFromTheBudgetWithoutTransport - priceTickets;
            double neededMoney = priceTickets - moneyFromTheBudgetWithoutTransport;

            if (moneyFromTheBudgetWithoutTransport > priceTickets)
            {
                Console.WriteLine("Yes! You have " + ($"{money:f2}") + " leva left.");
            }

            else
            {
                Console.WriteLine("Not enough money! You need " + ($"{neededMoney:f2}") + " leva.");
            }




        }
    }
}
