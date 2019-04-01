using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            int startingExam = (examHour * 60) + examMin;
            int arrivalTime = (arrivalHour * 60) + arrivalMin;

            int differenceTime = arrivalTime - startingExam;

            //Console.WriteLine(differenceTime);

            if (differenceTime < -30)
            {
                Console.WriteLine("Early");
            }

            else if (differenceTime <= 0)
            {
                Console.WriteLine("On time");
            }

            else
            {
                Console.WriteLine("Late");
            }


            int hours = Math.Abs(differenceTime / 60);
            int min = Math.Abs(differenceTime % 60);

            if (hours > 0)
            {
                if (min < 10)
                {
                    Console.Write(hours + ":0" + min + "hours");
                }

                else
                {
                    Console.Write(hours + ":" + min + "hours");
                }
            }

            else
            {
                Console.Write(min + "minutes ");
            }


            if (differenceTime < 0)
            {
                Console.WriteLine(" before the start");
            }

            else
            {
                Console.WriteLine(" after the start");
            }


        }
    }
}
