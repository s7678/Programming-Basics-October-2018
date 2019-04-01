using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ProjectPrize
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int sumPoints = 0;


            for (int i = 1; i <= parts; i++)
            {
                int points = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    sumPoints += points * 2;
                }

                else
                {
                    sumPoints += points;
                }

            }


            double finalPrice = sumPoints * price;

            Console.WriteLine($"The project prize was {finalPrice:f2} lv.");
            
        }
    }
}
