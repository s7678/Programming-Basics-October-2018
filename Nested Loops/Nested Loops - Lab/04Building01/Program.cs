using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Building01
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            char index = 'L';

            for (int i = floors; i >= 1; i--)
            {
                for (int j = 0; j < rooms; j++)
                {
                    Console.Write($"{index}{i}{j} ");
                }

                Console.WriteLine();

                if (i%2==0)
                {
                    index = 'A';
                }

                else
                {
                    index = 'O';
                }
            }

        }
    }
}
