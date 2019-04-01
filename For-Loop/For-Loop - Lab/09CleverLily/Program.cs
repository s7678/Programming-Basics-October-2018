using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            double sumMoney = 0;
            int countToys = 0;
            int countMoneys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    countMoneys++;
                    sumMoney += 10*countMoneys;
                    
                }

                else
                {
                    countToys++;
                }
            }

            

            double brotherSealMoney = sumMoney - ( countMoneys* 1.00);
            double sellToys = countToys * priceToy;
            double totalMoney = brotherSealMoney + sellToys;
            

            if (totalMoney >= laundryPrice)
            {
                Console.WriteLine($"Yes! {(totalMoney - laundryPrice):f2}");
            }

           else
            {
                Console.WriteLine($"No! {(laundryPrice - totalMoney):f2}");
            }
        }
    }
}
