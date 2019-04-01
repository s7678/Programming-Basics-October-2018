using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForTheTrip = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int countDays = 0;
            int countSpend = 0;
            double diff = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double moneySaveSpend = double.Parse(Console.ReadLine());
                countDays++;
                if (action == "spend")
                {
                    countSpend++;
                    diff = money - moneySaveSpend;
                    money -= moneySaveSpend;
                    if (diff < 0)
                    {
                        money = 0;
                    }




                }


                else if (action == "save")
                {
                    countSpend = 0;
                    money += moneySaveSpend;
                }



                if (countSpend == 5)
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine(countDays);
                    break;
                }

                if (money >= moneyForTheTrip)
                {
                    Console.WriteLine($"You saved the money for {countDays} days.");
                    break;
                }
            }
        }
    }
}