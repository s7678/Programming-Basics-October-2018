using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxDiff = int.MinValue;
            int firstSum = 0;
            int lastSum = 0;
            int sum = 0;
            bool areTheyEqual = true;

            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                sum = num1 + num2;

                if (i == 0)
                {
                    firstSum = sum;
                    lastSum = sum;
                }

                if (sum != firstSum)
                {
                    areTheyEqual = false;
                }


                if (Math.Abs(sum - lastSum) > maxDiff)
                {
                    maxDiff = Math.Abs(sum - lastSum);
                }


                lastSum = sum;



            }


            if (areTheyEqual)
            {
                Console.WriteLine($"Yes, value={firstSum}");
            }

            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }


        }
    }
}
