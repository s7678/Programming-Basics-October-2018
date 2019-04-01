using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());

            if (age < 16 && sex == 'm')
            {
                Console.WriteLine("Master");
            }

            else if (age >= 16 && sex == 'm')
            {
                Console.WriteLine("Mr.");
            }

            else if (age < 16 && sex == 'f')
            {
                Console.WriteLine("Miss");
            }

            else if (age >= 16 && sex == 'f')
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}
