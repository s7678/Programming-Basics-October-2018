using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine().ToLower();
            string sweatshirt = "Sweatshirt";
            string shirt = "Shirt";
            string tShirt = "T-Shirt";
            string swimSuit = "Swim Suit";

            string sneakers = "Sneakers";
            string moccasins = "Moccasins";
            string sandals = "Sandals";
            string barefoot = "Barefoot";



            if (degrees >= 10 && degrees <= 18)
            {
                if (time == "morning")
                {
                    Console.WriteLine("It's " + degrees + " degrees, get your " + sweatshirt + " and " + sneakers + ".");


                }

                else if (time == "afternoon")
                {
                    Console.WriteLine("It's " + degrees + " degrees, get your " + shirt + " and " + moccasins + ".");
                }

                else if (time == "evening")
                {
                    Console.WriteLine("It's " + degrees + " degrees, get your " + shirt + " and " + moccasins + ".");
                }

            }

            else if (degrees > 19 && degrees <= 24)
            {
                if (time == "morning")
                {
                    Console.WriteLine("It's " + degrees + " degrees, get your " + shirt + " and " + moccasins + ".");


                }

                else if (time == "afternoon")
                {
                    Console.WriteLine("It's " + degrees + " degrees, get your " + tShirt + " and " + sandals + ".");
                }

                else if (time == "evening")
                {
                    Console.WriteLine("It's " + degrees + " degrees, get your " + shirt + " and " + moccasins + ".");
                }

            }

            else if (degrees >= 25)
            {
                if (time == "morning")
                {
                    Console.WriteLine("It's " + degrees + " degrees, get your " + tShirt + " and " + sandals + ".");


                }

                else if (time == "afternoon")
                {
                    Console.WriteLine("It's " + degrees + " degrees, get your " + swimSuit + " and " + barefoot + ".");
                }

                else if (time == "evening")
                {
                    Console.WriteLine("It's " + degrees + " degrees, get your " + shirt + " and " + moccasins + ".");
                }

            }




        }
    }
}
