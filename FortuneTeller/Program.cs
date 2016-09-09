using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to my Fortune Teller App.  With a little bit of information from you in will be able to tell your future.");

            Console.WriteLine("Please enter your First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age:");
            string userAge = Console.ReadLine();

            Console.WriteLine("Please enter the month you were born 1 to 12.");
            int bMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your favorite ROYGBIV color. Type \"Help\" to get a list of the ROYGBIV Colors.");
            string royGbiv = Console.ReadLine());

               if (royGbiv.ToLower() == "help")
                     {

                     }


            

        }
    }
}
