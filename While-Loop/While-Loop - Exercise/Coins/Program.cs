using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double dip = double.Parse(Console.ReadLine());
            dip *= 100;
            int coins = 0;
            while (dip>=200)
            {
                dip -= 200;
                coins++;
            }

            while (dip>=100)
            {
                dip -= 100;
                coins++;
            }

            while (dip>=50)
            {
                dip -= 50;
                coins++;
            }

            while (dip>=20)
            {
                dip -= 20;
                coins++;
            }

            while (dip>=10)
            {
                dip -= 10;
                coins++;
            }

            while (dip>=5)
            {
                dip -= 5;
                coins++;
            }

            while (dip>=2)
            {
                dip -= 2;
                coins++;
            }

            while (dip>=1)
            {
                dip -= 1;
                coins++;
            }


            Console.WriteLine(coins);
        }
    }
}
