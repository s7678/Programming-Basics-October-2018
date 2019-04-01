using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            double mmInM = 1 / 1000.00;
            double cmInM = 1 / 100.00;
            double miInM = 1 / 0.000621371192;
            double inInM = 1 / 39.3700787;
            double kmInM = 1 / 0.001;
            double ftInM = 1 / 3.2808399;
            double ydInM = 1 / 1.0936133;

            

            double mInMM = 1000;
            double mInCm = 100;
            double mInMi = 0.000621371192;
            double mInIn = 39.3700787;
            double mInKm = 0.001;
            double mInFt = 3.2808399;
            double mInYd = 1.0936133;

            double result = 0;

            if (inputMetric == "mm" && outputMetric == "mm") result = num;
            else if (inputMetric == "cm" && outputMetric == "cm") result = num;
            else if (inputMetric == "mi" && outputMetric == "mi") result = num;
            else if (inputMetric == "in" && outputMetric == "in") result = num;
            else if (inputMetric == "km" && outputMetric == "km") result = num;
            else if (inputMetric == "ft" && outputMetric == "ft") result = num;
            else if (inputMetric == "yd" && outputMetric == "yd") result = num;
            else if (inputMetric == "m" && outputMetric == "m") result = num;


            if (inputMetric == "m" && outputMetric == "mm") result = num * mInMM;
            else if (inputMetric == "m" && outputMetric == "cm") result = num * mInCm;
            else if (inputMetric == "m" && outputMetric == "mi") result = num * mInMi;
            else if (inputMetric == "m" && outputMetric == "in") result = num * mInIn;
            else if (inputMetric == "m" && outputMetric == "km") result = num * mInKm;
            else if (inputMetric == "m" && outputMetric == "ft") result = num * mInFt;
            else if (inputMetric == "m" && outputMetric == "yd") result = num * mInYd;

            if (inputMetric == "mm" && outputMetric == "m") result = num * mmInM;
            else if (inputMetric == "cm" && outputMetric == "m") result = num * cmInM;
            else if (inputMetric == "mi" && outputMetric == "m") result = num * miInM;
            else if (inputMetric == "in" && outputMetric == "m") result = num * inInM;
            else if (inputMetric == "km" && outputMetric == "m") result = num * kmInM;
            else if (inputMetric == "ft" && outputMetric == "m") result = num * ftInM;
            else if (inputMetric == "yd" && outputMetric == "m") result = num * ydInM;

            if (inputMetric == "mm" && outputMetric == "cm") result = num * (mmInM / cmInM);
            else if (inputMetric == "mm" && outputMetric == "mi") result = num * (mmInM / miInM);
            else if (inputMetric == "mm" && outputMetric == "in") result = num * (mmInM / inInM);
            else if (inputMetric == "mm" && outputMetric == "km") result = num * (mmInM / kmInM);
            else if (inputMetric == "mm" && outputMetric == "ft") result = num * (mmInM / ftInM);
            else if (inputMetric == "mm" && outputMetric == "yd") result = num * (mmInM / ydInM);

            if (inputMetric == "cm" && outputMetric == "mm") result = num * (cmInM / mmInM);
            else if (inputMetric == "cm" && outputMetric == "mi") result = num * (cmInM / miInM);
            else if (inputMetric == "cm" && outputMetric == "in") result = num * (cmInM / inInM);
            else if (inputMetric == "cm" && outputMetric == "km") result = num * (cmInM / kmInM);
            else if (inputMetric == "cm" && outputMetric == "ft") result = num * (cmInM / ftInM);
            else if (inputMetric == "cm" && outputMetric == "yd") result = num * (cmInM / ydInM);

            if (inputMetric == "mi" && outputMetric == "mm") result = num * (miInM / mmInM);
            else if (inputMetric == "mi" && outputMetric == "cm") result = num * (miInM / cmInM);
            else if (inputMetric == "mi" && outputMetric == "in") result = num * (miInM / inInM);
            else if (inputMetric == "mi" && outputMetric == "km") result = num * (miInM / kmInM);
            else if (inputMetric == "mi" && outputMetric == "ft") result = num * (miInM / ftInM);
            else if (inputMetric == "mi" && outputMetric == "yd") result = num * (miInM / ydInM);

            if (inputMetric == "in" && outputMetric == "mm") result = num * (inInM / mmInM);
            else if (inputMetric == "in" && outputMetric == "mi") result = num * (inInM / miInM);
            else if (inputMetric == "in" && outputMetric == "cm") result = num * (inInM / cmInM);
            else if (inputMetric == "in" && outputMetric == "km") result = num * (inInM / kmInM);
            else if (inputMetric == "in" && outputMetric == "ft") result = num * (inInM / ftInM);
            else if (inputMetric == "in" && outputMetric == "yd") result = num * (inInM / ydInM);

            if (inputMetric == "km" && outputMetric == "mm") result = num * (kmInM / mmInM);
            else if (inputMetric == "km" && outputMetric == "mi") result = num * (kmInM / miInM);
            else if (inputMetric == "km" && outputMetric == "in") result = num * (kmInM / inInM);
            else if (inputMetric == "km" && outputMetric == "cm") result = num * (kmInM / cmInM);
            else if (inputMetric == "km" && outputMetric == "ft") result = num * (kmInM / ftInM);
            else if (inputMetric == "km" && outputMetric == "yd") result = num * (kmInM / ydInM);

            if (inputMetric == "ft" && outputMetric == "mm") result = num * (ftInM / mmInM);
            else if (inputMetric == "ft" && outputMetric == "mi") result = num * (ftInM / miInM);
            else if (inputMetric == "ft" && outputMetric == "in") result = num * (ftInM / inInM);
            else if (inputMetric == "ft" && outputMetric == "km") result = num * (ftInM / kmInM);
            else if (inputMetric == "ft" && outputMetric == "cm") result = num * (ftInM / cmInM);
            else if (inputMetric == "ft" && outputMetric == "yd") result = num * (ftInM / ydInM);

            if (inputMetric == "yd" && outputMetric == "mm") result = num * (ydInM / mmInM);
            else if (inputMetric == "yd" && outputMetric == "mi") result = num * (ydInM / miInM);
            else if (inputMetric == "yd" && outputMetric == "in") result = num * (ydInM / inInM);
            else if (inputMetric == "yd" && outputMetric == "km") result = num * (ydInM / kmInM);
            else if (inputMetric == "yd" && outputMetric == "ft") result = num * (ydInM / ftInM);
            else if (inputMetric == "yd" && outputMetric == "cm") result = num * (ydInM / cmInM);



            Console.WriteLine($"{result:f8}");





        }
    }
}
