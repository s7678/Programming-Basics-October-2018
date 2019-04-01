using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                string word = Console.ReadLine();
                if (word == "Going home")
                {
                    int stepsHome = int.Parse(Console.ReadLine());
                    sum += stepsHome;
                    if (sum < 10000)
                    {
                        int moreSteps = 10000 - sum;
                        Console.WriteLine($"{moreSteps} more steps to reach goal.");
                    }

                    else
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                    break;
                }
                int steps = int.Parse(word);

                sum += steps;
                if (sum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }
                

                

               

            }
        }
    }
}
