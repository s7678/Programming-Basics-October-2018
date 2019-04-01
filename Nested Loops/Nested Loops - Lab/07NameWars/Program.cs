using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxValue = int.MinValue;
            string winner = "";
            

            while (name!="STOP")
            {
                int sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];
                }

                if (sum>maxValue)
                {
                    maxValue = sum;
                   winner = name;
                }

                name = Console.ReadLine();
            }
            

            Console.WriteLine($"Winner is {winner} - {maxValue}!");


        }
    }
}
