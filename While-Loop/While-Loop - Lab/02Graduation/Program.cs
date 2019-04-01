using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0;
            int counter = 1;

            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    sum += grade;
                    counter++;

                }
                



            }
            double average = sum / 12;

            Console.WriteLine(name + " graduated. Average grade: " + ($"{average:f2}"));
            
        }
    }
}
