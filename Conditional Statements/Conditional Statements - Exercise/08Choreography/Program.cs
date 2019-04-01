using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double stepsPerDay = (steps / days);
            double stepsPerDayInPercent = Math.Ceiling((stepsPerDay / steps) * 100);

            double percentStepsPerOneDancer = stepsPerDayInPercent / dancers;

            double allPercentSteps = percentStepsPerOneDancer * dancers;

            if (allPercentSteps <= 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! " + ($"{percentStepsPerOneDancer:f2}" + "%."));
            }

            else if (allPercentSteps > 13)
            {
                Console.WriteLine("No, They will not succeed in that goal! Required " + ($"{percentStepsPerOneDancer:f2}") + "% steps to be learned per day.");
            }


        }
    }
}
