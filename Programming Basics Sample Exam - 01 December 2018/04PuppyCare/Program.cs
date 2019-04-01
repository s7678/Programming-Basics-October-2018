using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04PuppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodInKg = int.Parse(Console.ReadLine());

            int counterSumFood = 0;
            int foodInGrams = foodInKg * 1000;
            

            while (true)
            {
                string command = Console.ReadLine();
                if (command== "Adopted")
                {
                    if (counterSumFood<=foodInGrams)
                    {
                        Console.WriteLine($"Food is enough! Leftovers: {Math.Abs(counterSumFood-foodInGrams)} grams.");
                        break;
                        
                    }

                    else
                    {
                        Console.WriteLine($"Food is not enough. You need {Math.Abs(foodInGrams-counterSumFood)} grams more.");
                        break;
                        
                    }

                }

                int food = int.Parse(command);

                counterSumFood += food;

            }
        }
    }
}
