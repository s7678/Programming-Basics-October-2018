using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            double bgnToUsd = 1 / 1.79549;
            double bgnToEur = 1 / 1.95583;
            double bgnToGbp = 1 / 2.53405;

            double usdToBgn = 1.79549;
            double eurToBgn = 1.95583;
            double gbpToBgn = 2.53405;

            double usdToEur = 1.79549 / 1.95583;
            double usdToGbp = 1.79549 / 2.53405;

            double eurToUsd = 1.95583 / 1.79549;
            double eurToGbp = 1.95583 / 2.53405;

            double gbpToEur = 2.53405 / 1.95583;
            double gbpToUsd = 2.53405 / 1.79549;

            double result = 0;

            if (inputCurrency == "BGN" && outputCurrency == "USD") result = num * bgnToUsd;
            else if (inputCurrency == "BGN" && outputCurrency == "EUR") result = num * bgnToEur;
            else if (inputCurrency == "BGN" && outputCurrency == "GBP") result = num * bgnToGbp;

            if (inputCurrency == "USD" && outputCurrency == "BGN") result = num * usdToBgn;
            else if (inputCurrency == "EUR" && outputCurrency == "BGN") result = num * eurToBgn;
            else if (inputCurrency == "GBP" && outputCurrency == "BGN") result = num * gbpToBgn;

            if (inputCurrency == "USD" && outputCurrency == "EUR") result = num * usdToEur;
            else if (inputCurrency == "USD" && outputCurrency == "GBP") result = num * usdToGbp;

            if (inputCurrency == "EUR" && outputCurrency == "USD") result = num * eurToUsd;
            else if (inputCurrency == "EUR" && outputCurrency == "GBP") result = num * eurToGbp;

            if (inputCurrency == "GBP" && outputCurrency == "EUR") result = num * gbpToEur;
            else if (inputCurrency == "GBP" && outputCurrency == "USD") result = num * gbpToUsd;

            Console.WriteLine($"{result:f2}");







        }
    }
}
