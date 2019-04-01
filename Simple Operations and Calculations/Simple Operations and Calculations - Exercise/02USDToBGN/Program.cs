using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02USDToBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());

            double usdToBgn = usd * 1.79549;

            Console.WriteLine($"{usdToBgn:f2}");
        }
    }
}
