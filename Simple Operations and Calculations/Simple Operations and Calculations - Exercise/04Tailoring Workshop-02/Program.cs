using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Tailoring_Workshop_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double sideBox = lenght / 2.00;

            double sideA = lenght + (2 * 0.30);
            double sideB = width + (2 * 0.3);
            double rectangleTables = tables * (sideA * sideB);
            double boxTables = tables * (sideBox * sideBox);

            double usdPriceRectangle = rectangleTables * 7;
            double usdPriceBox = boxTables * 9;

            
            

            double bgnPriceRectangle = usdPriceRectangle * 1.85;
            double bgnPriceBox = usdPriceBox * 1.85;

            double totalUsd = usdPriceRectangle + usdPriceBox;
            double totalBgn = bgnPriceRectangle + bgnPriceBox;

            Console.WriteLine(($"{totalUsd:f2}") +" USD");
            Console.WriteLine(($"{totalBgn:f2}")+" BGN");
        }

    }

}






