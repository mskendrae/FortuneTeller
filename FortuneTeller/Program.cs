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
                Console.WriteLine("The ROYGBIV are as follows. Please type the name of your favorite color.");
                Console.WriteLine("1. Red");
                Console.WriteLine("2. Orange");
                Console.WriteLine("3. Yellow");
                Console.WriteLine("4. Green");
                Console.WriteLine("5. Blue");
                Console.WriteLine("6. Indigo");
                Console.WriteLine("7. Violet");

            }
            else if (royGbiv.ToLower() == "red")
            {
                string vehicle = "boat";
            }

            else if (royGbiv.ToLower() == "Orange")
            {
                string vehicle = "car";

            }

            else if (royGbiv.ToLower() == "yellow")
            {

                string vehicle = "plane";
            }

            else if (royGbiv.ToLower() == "green")
            {

                string vehicle = "motorcycle";
            }

            else if (royGbiv.ToLower() == "blue")
            {

                string vehicle = "glider";

            }
            else if (royGbiv.ToLower() == "indigo")
            {

                string vehicle = "bicycle";
            }

            else if (royGbiv.ToLower() == "violet")
            {
                string vehicle = "sea plane";

            }


        }
    }
}
