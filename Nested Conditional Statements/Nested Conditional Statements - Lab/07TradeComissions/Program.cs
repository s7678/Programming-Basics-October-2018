using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            bool isInvalidTown = town != "Sofia" && town != "Varna" && town != "Plovdiv";
            bool isInvalidSales = sales < 0;
            double total = 0;


            if (isInvalidTown || isInvalidSales)
            {
                Console.WriteLine("error");
            }

            else
            {
                if (town == "Sofia")
                {
                    if (sales > 0 && sales <= 500)
                    {
                        total = sales * 0.05;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        total = sales * 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        total = sales * 0.08;
                    }
                    else if (sales > 10000)
                    {
                        total = sales * 0.12;
                    }
                }

                else if (town == "Varna")
                {
                    if (sales > 0 && sales <= 500)
                    {
                        total = sales * 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        total = sales * 0.075;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        total = sales * 0.10;
                    }
                    else if (sales > 10000)
                    {
                        total = sales * 0.13;
                    }
                }

                else if (town == "Plovdiv")
                {
                    if (sales > 0 && sales <= 500)
                    {
                        total = sales * 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        total = sales * 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        total = sales * 0.12;
                    }
                    else if (sales > 10000)
                    {
                        total = sales * 0.145;
                    }
                }

                Console.WriteLine($"{total:f2}");
            }


        }
    }
}
