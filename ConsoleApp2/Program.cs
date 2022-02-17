using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Take an input from user, multiply it by 50, then print the result to console. (Note: make sure your code can take inputs larger than 10,000,000).
            Console.WriteLine("Please give a number between 1 and 10,000,000");
            string myNumber1 = Console.ReadLine();
            int myMultiplication = Convert.ToInt16(myNumber1) * 50;
            Console.WriteLine("You number times 50 = " + myMultiplication);
            Console.ReadLine();
            //2.Takes an input from the user, adds 25 to it, then prints the result to the console.
            Console.WriteLine("Please give me a number between 1 - 1,000: ");
            string myNumber2 = Console.ReadLine();
            int myAddition = Convert.ToInt16(myNumber2) + 25;
            Console.WriteLine("Your number plus 25 = " + myAddition);
            Console.ReadLine();
            //3.Takes an input from the user, divides it by 12.5, then prints the result to the console.
            Console.WriteLine("Please give me your favorite number: ");
            string myNumber3 = Console.ReadLine();
            double myQuotient = Convert.ToDouble(myNumber3) / 12.5;
            Console.WriteLine("Your favorite number divided by 12.5 = " + myQuotient);
            Console.ReadLine();
            //4.Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
            Console.WriteLine("Please give me a number between 1 - 100: ");
            string myNumber4 = Console.ReadLine();
            int myNumber5 = Convert.ToInt16(myNumber4);
            bool greaterOrNot = myNumber5 > 50;
            Console.WriteLine("Is your number greater than 50: True or False: " + greaterOrNot);
            Console.ReadLine();
            //5.Takes an input from the user, divides it by 7, then prints the remainder to the console (tip: think % operator).
            Console.WriteLine("Please provide another number (I promise we are almost done): ");
            string myNumber6 = Console.ReadLine();
            int myModulus = Convert.ToInt32(myNumber6) % 7;
            Console.WriteLine("What is the remainder of your number divided by 7 = " + myModulus);
            Console.ReadLine();
            Console.WriteLine("Thank you for going through my ConsoleApp2. Have a nice day.");
            Console.ReadLine();

        }
    }
}
