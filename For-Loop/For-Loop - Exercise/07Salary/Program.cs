using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tab = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int penalty = 0;



            for (int i = 0; i < tab; i++)
            {
                string webSite = Console.ReadLine();
                if (webSite == "Facebook")
                {
                    penalty = 150;
                    salary -= penalty;

                }

                if (webSite == "Instagram")
                {
                    penalty = 100;
                    salary -= penalty;
                }

                if (webSite == "Reddit")
                {
                    penalty = 50;
                    salary -= penalty;
                }
            }

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }

            else
            {
                Console.WriteLine(salary);

            }




        }
    }
}
