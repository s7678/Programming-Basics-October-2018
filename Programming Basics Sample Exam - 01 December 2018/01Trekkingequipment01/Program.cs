using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Trekkingequipment01
{
    class Program
    {
        static void Main(string[] args)
        {
            int alpinist = int.Parse(Console.ReadLine());
            int carabineri = int.Parse(Console.ReadLine());
            int rope = int.Parse(Console.ReadLine());
            int pikeli = int.Parse(Console.ReadLine());


            double carabineriForOneAlpinist = carabineri * 36;
            double ropeForOneAlpinist = rope * 3.60;
            double pikeliForOneAlpinist = pikeli * 19.80;

            double equipmentForOneAlpin = carabineriForOneAlpinist + ropeForOneAlpinist + pikeliForOneAlpinist;
            double allequipment = equipmentForOneAlpin * alpinist;

            double dds = allequipment * 0.20;

            double total = allequipment + dds;

            Console.WriteLine($"{total:f2}");
        }
    }
}
