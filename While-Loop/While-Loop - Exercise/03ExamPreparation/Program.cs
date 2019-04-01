using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProblems = 0;
            int notGooDGrades = int.Parse(Console.ReadLine());
            double sum = 0;
            string lastProblem = string.Empty;
            int countBadGrades = 0;
            while (true)
            {
                string problem = Console.ReadLine();

                if (problem == "Enough")
                {
                    Console.WriteLine($"Average score: {(sum / numberOfProblems):f2}");
                    Console.WriteLine($"Number of problems: {numberOfProblems}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;

                }

                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4.00)
                {
                    countBadGrades++;
                    if (notGooDGrades == countBadGrades)
                    {
                        Console.WriteLine($"You need a break, {notGooDGrades} poor grades.");
                        break;
                    }
                }

                lastProblem = problem;
                sum += grade;
                numberOfProblems++;
                

            }
        }
    }
}