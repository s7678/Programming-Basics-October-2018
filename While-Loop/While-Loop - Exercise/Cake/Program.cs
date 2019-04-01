using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());

            int cakeArea = lenght * widht;

            int sum = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "STOP")
                {
                    if (sum < cakeArea)
                    {
                        Console.WriteLine($"{cakeArea - sum} pieces are left.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine($"No more cake left! You need {sum - cakeArea} pieces more.");
                        break;
                    }

                }

                int piece = int.Parse(command);

                sum += piece;


                if (sum > cakeArea)
                {
                    Console.WriteLine($"No more cake left! You need {sum - cakeArea} pieces more.");
                    break;
                }

            }
        }
    }
}
