using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Numbersequence
{
    class Program
    {
        static void Main(string[] args)
        {


            int minNum = int.MaxValue;
            int maxNum = int.MinValue;


            while (true)
            {
                string word = Console.ReadLine();
                if (word == "END")
                {
                    break;
                }
                int num = int.Parse(word);

                if (num < minNum)
                {
                    minNum = num;

                }

                if (num > maxNum)
                {
                    maxNum = num;

                }


            }

            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");




        }
    }
}
