using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double bonusPoints = 0;

            if (num <= 100)
            {
                bonusPoints = 5;
            }

            else if (num > 100 && num <= 1000)
            {
                bonusPoints = num * 0.20;
            }

            else if (num > 1000)
            {
                bonusPoints = num * 0.10;

            }



            if (num % 2 == 0)
            {
                bonusPoints += 1;
            }

            else if (num % 10 == 5)
            {
                bonusPoints += 2;
            }

            

            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints+num);

        }
    }
}
