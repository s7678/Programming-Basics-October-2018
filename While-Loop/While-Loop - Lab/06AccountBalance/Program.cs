using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfIncrease = double.Parse(Console.ReadLine());
            double increase = 0;
            double sum = 0;
            int counterOfIncreases = 0;
            while (true)
            {
                increase = double.Parse(Console.ReadLine());

                if (increase < 0)
                {
                    sum += 0;
                    Console.WriteLine($"Invalid operation!");

                    break;

                }


                if (counterOfIncreases < numberOfIncrease && increase > 0)
                {
                    Console.WriteLine($"Increase: {increase:f2}");
                    sum += increase;
                    counterOfIncreases++;

                }

                if (counterOfIncreases == numberOfIncrease)
                {
                    break;
                }
                
            }

            Console.WriteLine($"Total: {sum:f2}");


        }
    }
}
