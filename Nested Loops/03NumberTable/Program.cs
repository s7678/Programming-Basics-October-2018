using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    current = i + j + 1;
                    if (current>n)
                    {
                        current = 2 * n - current;
                    }
                    Console.Write($"{current} ");

                }
                Console.WriteLine();
            }
        }
    }
}
