using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double fests = double.Parse(Console.ReadLine());
            double weekends = double.Parse(Console.ReadLine());

            double totalWeekends = (48 - weekends) * (3.0 / 4.0);

            double totalFests = fests * (2.0 / 3.0);


            double total = totalWeekends + totalFests + weekends;



            if (year == "leap")
            {
                double leapYear = total + (total * 0.15);
                Console.WriteLine(Math.Floor(leapYear));
            }

            else
            {
                Console.WriteLine(Math.Floor(total));
            }


        }
    }
}
