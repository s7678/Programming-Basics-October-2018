﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Sequence2k1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int newNum = 1;
            
            
            while (newNum <= num)
            {
                Console.WriteLine(newNum);

                newNum = (newNum * 2) + 1;
                

            }
        }
    }
}
