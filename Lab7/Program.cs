using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //write a program that validates user name
            Console.WriteLine("Please enter a valid Name: ");
            string userInput = Console.ReadLine();
            while (!Regex.IsMatch(userInput, @"^[A-Z]{1}[a-zA-Z]{0,29}$"))
            //escape sequence; so that you can do and "@" or print "quotes" ( \n \t \'' \\ )
            //the @ first turns off all escape sequences
            {
                Console.WriteLine("Sorry, name is not valid!");
                userInput = Console.ReadLine(); //loops back through the original prompt until valid input
            }


            //write a program that validates email
            Console.Write("Please enter a valid email: ");
            string emailInput = Console.ReadLine();
            while(!Regex.IsMatch(emailInput, @"^[a-zA-Z\d]{1,30}\@[a-zA-Z\d]{5,30}\..[a-z]{2,3}$"))
            {
                Console.WriteLine("Sorry, email is not valid!");
                emailInput = Console.ReadLine();
            }
            while (Regex.IsMatch(emailInput, @"^[a-zA-Z\d]{1,30}\@[a-zA-Z\d]{5,30}\..[a-z]{2,3}$"))
            {
                Console.WriteLine("Email is valid!");
                break;
            }

            //write a program that validates phone number
            Console.WriteLine("Please enter a valid phone number: ");
            string phoneNumberInput = Console.ReadLine();
            while (!Regex.IsMatch(phoneNumberInput, @"^\d{3}\-\d{3}\-\d{4}$"))
            {
                Console.WriteLine("Sorry, phone number is not valid!");
                phoneNumberInput = Console.ReadLine();
            }
            while (Regex.IsMatch(phoneNumberInput, @"^\d{3}\-\d{3}\-\d{4}$"))
            {
                Console.WriteLine();
                phoneNumberInput = Console.ReadLine();
            }
            //check if the user input matches the pattern (regular expression)
            // class Regex (see above the using statement for the Regex class made above)
            // IsMatch (look at right click debug "quick fix"

           

            /*if (Regex.IsMatch(emailInput, @"^.{0,30}\@.{5,30}\..{2,3}$"))
            {
                Console.WriteLine("Email is valid!");
            }
           
            if (Regex.IsMatch(phoneNumberInput, @"^\d{3}\-\d{3}\-\d{4}$"))
            {
                Console.Write(phoneNumberInput);
            }

            //validation
            while (!Regex.IsMatch(userInput, @"^[A-Z{1}[a-zA-Z]{0,29}$"))
            {
                Console.WriteLine("Sorry, name is not valid!");
            }
            while (!Regex.IsMatch(emailInput, @"^[A-Z{1}[a-zA-Z]{0,29}$"))
            {
                Console.WriteLine("Sorry, email is not valid!");
            }
            */
            /*while (!Regex.IsMatch(emailInput, @"^.{0,30}\@.{5,30}\..{2,3}$"))
            {
                Console.WriteLine("Nice try! next time please do it right!");
            }   
            while (!Regex.IsMatch(phoneNumberInput, @"^\d{3}\-\d{3}\-\d{4}$"))
            {
                Console.WriteLine("Nice try! next time please do it right!");
            }
            Console.WriteLine("You entered a valid zip code!");*/
           
        }
    }
}
