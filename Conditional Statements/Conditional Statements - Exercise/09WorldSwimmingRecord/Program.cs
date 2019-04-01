using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distansInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double ivanchoTime = distansInMeters * timeInSeconds;
            
            double ivanchoTimeDistanse = Math.Floor(distansInMeters / 15.00);
            double ivanchoTimeWithResistanse = ivanchoTimeDistanse * 12.5;

            double totalIvanchoTime = ivanchoTime + ivanchoTimeWithResistanse;


            double neededTime = Math.Abs(record - totalIvanchoTime);

            if (totalIvanchoTime >= record)
            {
                Console.WriteLine("No, he failed! He was " + ($"{neededTime:f2}") + " seconds slower.");

            }

            else
            {
                Console.WriteLine("Yes, he succeeded! The new world record is " + ($"{totalIvanchoTime:f2}") + " seconds.");
            }

        }
    }
}
