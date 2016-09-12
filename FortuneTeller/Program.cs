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
                int userAge = int.Parse(Console.ReadLine());
                int retire = 0;

                if (userAge % 2 == 0)
                {
                    int evenAge = userAge;

                    retire = 10;
                }
                else
                {
                    int oddAge = userAge;

                    retire = 20;

                }


                Console.WriteLine("Please enter the month you were born 1 to 12 no leading zeros please");
                int bMonth = int.Parse(Console.ReadLine());
                int savings = 0;

                if (bMonth >= 1 && bMonth <= 4)
                {
                    savings = 100000;

                }
                else if (bMonth >= 5 && bMonth <= 8)
                {

                    savings = 200000;
                }

                else if (bMonth >= 9 && bMonth <= 12)
                {

                    savings = 500000;
                }
                else
                {
                    savings = 0;

                }


                Console.WriteLine("Please enter your favorite ROYGBIV color. Type \"Help\" to get a list of the ROYGBIV Colors.");
                string royGbiv = Console.ReadLine();
                string vehicle = "yellow sub";

                if (royGbiv.ToLower() == "help")
                {
                    Console.WriteLine("The ROYGBIV are as follows. Please type the name of your favorite color not the number.");
                    Console.WriteLine("1. Red");
                    Console.WriteLine("2. Orange");
                    Console.WriteLine("3. Yellow");
                    Console.WriteLine("4. Green");
                    Console.WriteLine("5. Blue");
                    Console.WriteLine("6. Indigo");
                    Console.WriteLine("7. Violet");
                    Console.WriteLine("Please enter color name and not the number.");
                    royGbiv = Console.ReadLine();

                }

                if (royGbiv.ToLower() == "red")
                {
                    vehicle = "yaht";
                }

                else if (royGbiv.ToLower() == "Orange")
                {
                    vehicle = "classic Mustang";

                }

                else if (royGbiv.ToLower() == "yellow")
                {
                    vehicle = "private Jet";

                }

                else if (royGbiv.ToLower() == "green")
                {
                    vehicle = "Harley Davidson";

                }

                else if (royGbiv.ToLower() == "blue")
                {
                    vehicle = "glider";

                }

                else if (royGbiv.ToLower() == "indigo")
                {
                    vehicle = "Shwinn bicycle";

                }

                else if (royGbiv.ToLower() == "violet")
                {
                    vehicle = "sea plane";

                }


                Console.WriteLine("Please enter the number of siblings you have");
                int siblings = int.Parse(Console.ReadLine());
                string vacationLocation = "outhouse";

                if (siblings == 0)
                {

                    vacationLocation = "Italy";
                }

                else if (siblings == 1)
                {

                    vacationLocation = "Scotland";
                }

                else if (siblings == 2)
                {

                    vacationLocation = "Florida Coast";
                }

                else if (siblings == 3)
                {

                    vacationLocation = "the moon";
                }

                else if (siblings > 3)
                {
                    vacationLocation = "South Dakota";

                }

                Console.WriteLine(firstName + " " + lastName + " will retire in " + retire + " with " + savings + " in the bank, a vacation home in " + vacationLocation + " and a " + vehicle);   

                }
            }
        }

    }
}
