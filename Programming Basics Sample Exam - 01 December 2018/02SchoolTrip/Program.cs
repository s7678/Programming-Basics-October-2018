using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SchoolTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double foodForFirstDogDay = double.Parse(Console.ReadLine());
            double foodForSecondDogDay = double.Parse(Console.ReadLine());
            double foodForTherdDogDay = double.Parse(Console.ReadLine());

            double firstDog = days * foodForFirstDogDay;
            double secondDog = days * foodForSecondDogDay;
            double therdDog = days * foodForTherdDogDay;

            double dogsFood = firstDog + secondDog + therdDog;

            if (dogsFood <= food)
            {
                Console.WriteLine($"{Math.Floor(food - dogsFood)} kilos of food left.");
            }

            else if (dogsFood > food)
            {
                Console.WriteLine($"{Math.Ceiling(dogsFood - food)} more kilos of food are needed.");

            }
        }
    }
}
