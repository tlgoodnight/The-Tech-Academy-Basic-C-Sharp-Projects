using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the first a do/while statement - followed along with video
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            while (!isGuessed);
            Console.ReadLine();
        
            //This is my while loop 
            Console.WriteLine("Now lets find out your age?");
            int myAge = Convert.ToInt32(Console.ReadLine());
            bool oldAge = myAge == 50;

            while (!oldAge)
            {
                switch (myAge)
                {
                    case 25:
                        Console.WriteLine("You are 25. You are still young. Try another age.");
                        Console.WriteLine("What is your ideal age?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 35:
                        Console.WriteLine("You are 35 keep counting the years. Life is a journey. Try another age.");
                        Console.WriteLine("What is your ideal age?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You are 55. Time to reach out to AARP.");
                        Console.WriteLine("What is your ideal age?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 50:
                        Console.WriteLine("You are 50. That is the best age.");
                        oldAge = true;
                        break;
                    default:
                        Console.WriteLine("This is not the best age. Try again.");
                        Console.WriteLine("What is your ideal age?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            Console.ReadLine();
            }
        }
    }
}