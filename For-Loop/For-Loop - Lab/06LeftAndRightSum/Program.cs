using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfCoupels = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < countOfCoupels; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                leftSum += num1;


            }

            for (int y = 0; y < countOfCoupels; y++)
            {
                int num2 = int.Parse(Console.ReadLine());
                rightSum += num2;

            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }

            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
