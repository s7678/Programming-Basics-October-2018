using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Travelling
{
    class Program
    {
        static void Main(string[] args)
        {



            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                double budget = double.Parse(Console.ReadLine());
                double sum = 0;

                while (sum < budget)
                {

                    double save = double.Parse(Console.ReadLine());
                    sum += save;

                }
                Console.WriteLine($"Going to {command}!");


            }

        }
    }




}


