using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Threebrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrother = double.Parse(Console.ReadLine());
            double secondBrother = double.Parse(Console.ReadLine());
            double therdBrother = double.Parse(Console.ReadLine());
            double fishingTime = double.Parse(Console.ReadLine());

            double allTime = 1.00 / ((1.00 / firstBrother) + (1.00 / secondBrother) + (1.00 / therdBrother));

            double timeWithBreak = allTime + (allTime * 0.15);
            double surprise = fishingTime - timeWithBreak;

            if (surprise > 0)
            {

                Console.WriteLine("Cleaning time: " + ($"{timeWithBreak:f2}"));
                Console.WriteLine("Yes, there is a surprise - time left -> " + Math.Floor(surprise) + " hours.");

            }

            else if (surprise < 0)
            {
                double needTime = timeWithBreak - fishingTime;
                Console.WriteLine("Cleaning time: " + ($"{timeWithBreak:f2}"));
                Console.WriteLine("No, there isn't a surprise - shortage of time -> " + Math.Ceiling(needTime) + " hours.");
                
            }


        }
    }
}
