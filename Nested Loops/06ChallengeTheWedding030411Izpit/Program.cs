using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ChallengeTheWedding030411Izpit
{
    class Program
    {
        static void Main(string[] args)
        {
            int mans = int.Parse(Console.ReadLine());
            int womans = int.Parse(Console.ReadLine());
            int maxTabels = int.Parse(Console.ReadLine());


            for (int i = 1; i <= mans; i++)
            {
                for (int j = 1; j <= womans; j++)
                {
                    if (maxTabels == 0)
                    {
                        return;

                    }

                    Console.Write($"({i} <-> {j}) ");
                    maxTabels--;

                }
            }

            Console.WriteLine();
        }
    }
}
