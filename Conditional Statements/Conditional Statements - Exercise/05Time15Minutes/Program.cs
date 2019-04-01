using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            int minAfterFiftheenMin = min + 15;
            int minTransf = minAfterFiftheenMin - 60;


            if (minAfterFiftheenMin <= 59)
            {

                Console.WriteLine(hour + ":" + minAfterFiftheenMin);

            }


            else if (minAfterFiftheenMin > 59)
            {
                hour += 1;

                if (hour == 24)
                {
                    hour = 0;
                }
                if (minTransf < 10)
                {
                    Console.WriteLine(hour + ":0" + minTransf);
                }

                else
                {
                    Console.WriteLine(hour + ":" + minTransf);
                }


            }


        }
    }
}
