using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());
            int sum = 0;


            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            for (int m = 1; m <= 9; m++)
                            {
                                for (int n = 1; n <= 9; n++)
                                {
                                    sum = i * j * k * l * m * n;
                                    if (sum==magicNumber)
                                    {
                                        Console.Write($"{i}{j}{k}{l}{m}{n} ");

                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
