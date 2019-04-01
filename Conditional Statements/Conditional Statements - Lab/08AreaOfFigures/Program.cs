using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figur = Console.ReadLine();
            double area = 0;


            if (figur == "square")
            {
                double num = double.Parse(Console.ReadLine());
                area = num * num;

            }

            else if (figur == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                area = sideA * sideB;
            }

            else if (figur == "circle")
            {
                double r = double.Parse(Console.ReadLine());

                area = Math.PI * r * r;

            }

            else if (figur == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                area = (sideA * sideB) / 2;
            }


            Console.WriteLine($"{area:f3}");

        }
    }
}
