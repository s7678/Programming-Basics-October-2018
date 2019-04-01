using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double total = 0;
            bool isInvalidDay = day != "Monday" && day != "Tuesday" && day != "Wednesday" && day != "Thursday" && day != "Friday" && day != "Saturday" && day != "Sunday";
            bool isInvalidFruit = fruit != "banana" && fruit != "apple" && fruit != "orange" && fruit != "grapefruit" && fruit != "kiwi" && fruit != "pineapple" && fruit != "grapes";


            if (isInvalidDay || isInvalidFruit)
            {
                Console.WriteLine("error");
            }

            else
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    if (fruit == "banana")
                    {
                        total = quantity * 2.50;
                    }

                    else if (fruit == "apple")
                    {
                        total = quantity * 1.20;
                    }

                    else if (fruit == "orange")
                    {
                        total = quantity * 0.85;
                    }

                    else if (fruit == "grapefruit")
                    {
                        total = quantity * 1.45;
                    }

                    else if (fruit == "kiwi")
                    {
                        total = quantity * 2.70;
                    }

                    else if (fruit == "pineapple")
                    {
                        total = quantity * 5.50;
                    }

                    else if (fruit == "grapes")
                    {
                        total = quantity * 3.85;
                    }


                }

                else if (day == "Saturday" || day == "Sunday")
                {
                    if (fruit == "banana")
                    {
                        total = quantity * 2.70;
                    }

                    else if (fruit == "apple")
                    {
                        total = quantity * 1.25;
                    }

                    else if (fruit == "orange")
                    {
                        total = quantity * 0.90;
                    }

                    else if (fruit == "grapefruit")
                    {
                        total = quantity * 1.60;
                    }

                    else if (fruit == "kiwi")
                    {
                        total = quantity * 3.00;
                    }

                    else if (fruit == "pineapple")
                    {
                        total = quantity * 5.60;
                    }

                    else if (fruit == "grapes")
                    {
                        total = quantity * 4.20;
                    }
                }
            }

            Console.WriteLine($"{total:f2}");



        }
    }
}
