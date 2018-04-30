using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            // names
            Console.WriteLine("Please enter aValid name? ");
            string namedInput = Console.ReadLine();
            if (CheckNames(namedInput))
            {
                Console.WriteLine("That is a valid name.");
            }
            else
            {
                Console.WriteLine("not valid nqame");
            }

            // emails
            Console.WriteLine("Please enter a Valid Email? ");
            string emailInput = Console.ReadLine();
            if (CheckEmails(emailInput))
            {
                Console.WriteLine("that is a valid Email.");
            }
            else
            {
                Console.WriteLine("Not a valid Email!");
            }

            //dates
            Console.WriteLine("Please enter valid Date (MM / DD / YYYY)");
            string dateInput = Console.ReadLine();
            if (Checkdates(dateInput))
            {
                Console.WriteLine("Valid Date");
            }
            else
            {
                Console.WriteLine("not valid date!");
            }

            //phonenumbers
            Console.WriteLine("Please enter a valid phone Number? ");
            string phoneInput = Console.ReadLine();
            if (Phonenumbers(phoneInput))
            {
                Console.WriteLine("valid phone Number");
            }
            else
            {
                Console.WriteLine("not valid phone number");
            }

        }


        public static bool CheckNames(string input)//namers
        {
            if (Regex.IsMatch(input, @"^[A-Z][a-z A-Z 0-5]{0,29}$"))
            {
                return true;
            }
            return false;
        }


        public static bool CheckEmails(string input) //emails
        {
            if (Regex.IsMatch(input, @"^[a-zA-Z0-9]{5,30}@[a-zA-Z]{5,10}\.[a-zA-Z0-9]{2,3}$"))
            {
                return true;
            }
            return false;
        }


        public static bool Checkdates(string input)// dates, format(MM / DD / YYYY)
        {
            if (Regex.IsMatch(input, @"^(0[1-9]|1[0-2])\/(0[1-9]|1\d|2\d|3[01])\/(19|20)\d{2}$"))
            {
                return true;
            }
            return false;
        }


        public static bool Phonenumbers(string input) //phonenumbers
        {
            if (Regex.IsMatch(input, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}$"))
            {
                return true;
            }
            return false;
        }

    }
}
