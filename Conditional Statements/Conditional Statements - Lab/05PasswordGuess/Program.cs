using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {

            string userPassword = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";

            if (userPassword == password)
            {
                Console.WriteLine("Welcome");
            }

            else
            {
                Console.WriteLine("Wrong password");
            }






        }
    }
}
