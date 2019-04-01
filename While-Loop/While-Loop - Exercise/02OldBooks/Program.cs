using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int capasity = int.Parse(Console.ReadLine());
            int count = 0;
            bool foundTheBook = false;

            while (true)
            {

                string otherBook = Console.ReadLine();

                if (otherBook == book)
                {
                    foundTheBook = true;
                    //Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }

                count++;

                if (count == capasity)
                {
                   // Console.WriteLine($"The book you search is not here!");
                    //Console.WriteLine($"You checked {count} books.");
                    break;
                }

            }

            if (foundTheBook)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }

            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }













        }
    }
}
