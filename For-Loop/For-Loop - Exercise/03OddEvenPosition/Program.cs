using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;
            double evenSum = 0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;
         
            

            for (int i = 1; i <= n; i++)
            {
               double num = double.Parse(Console.ReadLine());
                if (n == 1 && num < 0)
                {
                    Console.WriteLine($"OddSum={num}");
                    Console.WriteLine($"OddMin={num}");
                    Console.WriteLine($"OddMax={num}");
                    Console.WriteLine($"EvenSum=0");
                    Console.WriteLine($"EvenMin=No");
                    Console.WriteLine($"EvenMax=No");
                    break;

                }

                if (n == 1 && num == 1)
                {
                    Console.WriteLine($"OddSum={num}");
                    Console.WriteLine($"OddMin={num}");
                    Console.WriteLine($"OddMax={num}");
                    Console.WriteLine($"EvenSum=0");
                    Console.WriteLine($"EvenMin=No");
                    Console.WriteLine($"EvenMax=No");


                }

                if (i % 2 == 0)
                {
                    evenSum += num;

                    if (num<evenMin)
                    {
                        evenMin = num;
                    }

                    if (num>evenMax)
                    {
                        evenMax = num;
                    }
                }

                else
                {
                    oddSum += num;
                    if (num<oddMin)
                    {
                        oddMin = num;
                    }

                    if (num>oddMax)
                    {
                        oddMax = num;
                    }
                }

                
            }

            if (n == 0)
            {
                Console.WriteLine($"OddSum=0");
                Console.WriteLine($"OddMin=No");
                Console.WriteLine($"OddMax=No");
                Console.WriteLine($"EvenSum=0");
                Console.WriteLine($"EvenMin=No");
                Console.WriteLine($"EvenMax=No");
                

            }

            
            else
            {
                Console.WriteLine($"OddSum={oddSum}");
                Console.WriteLine($"OddMin={oddMin}");
                Console.WriteLine($"OddMax={oddMax}");
                Console.WriteLine($"EvenSum={evenSum}");
                Console.WriteLine($"EvenMin={evenMin}");
                Console.WriteLine($"EvenMax={evenMax}");

            }

            
        }
    }
}
