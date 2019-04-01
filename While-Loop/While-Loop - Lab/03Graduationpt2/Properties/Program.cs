using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Graduationpt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 1;
            double sum = 0;
            double grade = 0;
            int badGrades = 0;


            while (counter <= 12)
            {
                grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    sum += grade;
                    if (counter==12)
                    {
                        double average = sum / 12;

                        Console.WriteLine(name + " graduated. Average grade: " + ($"{average:f2}"));
                        break;
                    }
                    counter++;

                }

                else
                {
                    badGrades++;
                    if (badGrades > 1)
                    {
                        Console.WriteLine(name + " has been excluded at " + counter + " grade");
                        break;
                    }

                }


            }


            





        }
    }
}
