using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int password = 0;



            for (char i = '#'; i <= '7'; i++)
            {
                if (i == '7')
                {
                    return;
                }


                for (char j = '@'; j <= '`'; j++)
                {
                    if (j == '`')
                    {
                        return;
                    }

                    for (int k = 1; k <= a; k++)
                    {
                        

                        for (int l = 1; l <= b; l++)
                        {
                            

                            for (char m = '@'; m <= '`'; m++)
                            {
                                if (m == '`')
                                {
                                    return;
                                }
                                for (char n = '#'; n <= '7'; n++)
                                {
                                    if (n == '7')
                                    {
                                        return;
                                    }
                                    password++;
                                    Console.Write($"{i}{j}{k}{l}{m}{n}|");

                                    if (password > max)
                                    {
                                        break;
                                    }
                                    else
                                    {

                                    }

                                }
                            }
                        }
                    }
                }
            }








        }
    }
}
