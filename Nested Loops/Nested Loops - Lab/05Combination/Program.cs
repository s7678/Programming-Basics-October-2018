using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    for (int k = 0; k <= n; k++)
                    {
                        for (int l = 0; l <= n; l++)
                        {
                            for (int m = 0; m <= n; m++)
                            {
                                sum = i + j + k + l + m;

                                if (sum == n)
                                {
                                    counter++;

                                }

                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"{counter}");
        }
    }
}
