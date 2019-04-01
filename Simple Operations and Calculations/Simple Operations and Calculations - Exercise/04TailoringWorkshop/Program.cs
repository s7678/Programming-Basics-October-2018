using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double sideARectangleTabel = lenght + (2 * 0.3);
            double sideBRectangleTabel = width + (2 * 0.3);
            double sideSquareTable = lenght/2;

            double usdToBgn = 1.85;

            double neededFabricForRectangleTable = tables * (sideARectangleTabel * sideBRectangleTabel);
            

            double neededfabricForSquareTable = tables * (sideSquareTable * sideSquareTable);
            

            double moneyInUsd = (neededFabricForRectangleTable * 7) + (neededfabricForSquareTable * 9);
            double moneyInBgn = moneyInUsd * usdToBgn;


            Console.WriteLine($"{moneyInUsd:f2}"+" USD");
            Console.WriteLine($"{moneyInBgn:f2}"+" BGN");





        }
    }
}
