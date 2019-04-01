using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Threebrothers_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double timeFirstBrother = double.Parse(Console.ReadLine());
            double timeSecondBrother = double.Parse(Console.ReadLine());
            double timeTherdBrother = double.Parse(Console.ReadLine());
            double timeFishingFather = double.Parse(Console.ReadLine());

            double totalTimeAllBrothers = 1.00 / ((1.00 / timeFirstBrother) + (1.00 / timeSecondBrother) + (1.00 / timeTherdBrother));
            double timeWithRest = totalTimeAllBrothers * 0.15;

            double timeLeft = timeFishingFather - timeWithRest;
            Console.WriteLine(timeWithRest);
            Console.WriteLine(timeLeft);


            if (timeLeft>0)
            {
                Console.WriteLine("Yes, there is a surprise - time left" + Math.Floor(timeLeft) + "hours.");

                
            }

            else
            {
                Console.WriteLine("No, there isn't a surprise - shortage of time ");

            }

        }
    }
}
