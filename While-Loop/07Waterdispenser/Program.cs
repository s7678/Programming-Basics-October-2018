using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Waterdispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            
            string program = "";
            int counter = 0;

            double sum = 0;

            while (true)
            {
                program = Console.ReadLine();

                if (program == "Easy")
                {
                    sum += 50;
                }

                else if (program == "Medium")
                {
                    sum += 100;
                }

                else if (program == "Hard")
                {
                    sum += 200;
                }

                counter++;


                if (sum >= volume)
                {
                    if (sum == volume)
                    {
                        Console.WriteLine($"The dispenser has been tapped {counter} times.");
                        break;
                    }

                    else if (sum > volume)
                    {
                        double spill = sum - volume;
                        Console.WriteLine($"{spill}ml has been spilled.");
                        break;
                    }
                }



            }
        }
    }
}
