using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int sport1 = int.Parse(Console.ReadLine());
            int sport2 = int.Parse(Console.ReadLine());
            int sport3 = int.Parse(Console.ReadLine());

            int sum = sport1 + sport2 + sport3;

            if (sum < 10)
            {
                Console.WriteLine("0:0" + sum);
            }

            if (sum >= 10 && sum <= 59)
            {
                Console.WriteLine("0:" + sum);
            }

            else if (sum >= 60 && sum <= 119)
            {
                int sec = sum - 60;
                if (sec<10)
                {
                    Console.WriteLine("1:0"+sec);
                }
                else
                {
                    Console.WriteLine("1:" + sec);

                }
                
            }
            else if (sum >= 120 && sum <= 179)
            {
                int sec = sum - 120;
                if (sec<10)
                {
                    Console.WriteLine("2:0"+sec);
                }
                else
                {
                    Console.WriteLine("2:" + sec);
                }
                
            }

            


        }
    }
}
