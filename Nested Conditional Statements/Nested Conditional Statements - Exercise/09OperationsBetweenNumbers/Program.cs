using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double sum = 0;
            double diff = 0;
            double multi = 0;
            double div = 0;
            double modul = 0;

            if (symbol == '+')
            {
                sum = n1 + n2;

                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} + {1} = {2} - even", n1, n2, sum);
                }

                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", n1, n2, sum);
                }
            }

            else if (symbol == '-')
            {
                diff = n1 - n2;

                if (diff % 2 == 0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", n1, n2, diff);
                }

                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", n1, n2, diff);
                }

            }

            else if (symbol == '*')
            {
                multi = n1 * n2;

                if (multi % 2 == 0)
                {
                    Console.WriteLine("{0} * {1} = {2} - even", n1, n2, multi);
                }

                else
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", n1, n2, multi);
                }

            }

            else if (symbol == '/')
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }

                else
                {
                    div = n1 / n2;
                    Console.WriteLine("{0} / {1} = {2}", n1, n2, ($"{div:f2}"));
                }

            }

            else if (symbol == '%')
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }

                else
                {
                    modul = n1 % n2;
                    Console.WriteLine("{0} % {1} = {2}", n1, n2, modul);
                }

            }


        }
    }
}
