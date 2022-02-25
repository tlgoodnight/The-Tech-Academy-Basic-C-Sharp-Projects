using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        {
            //This is part 1 - It is a stringArray that asks the user for input then adds that input to the end of the string. And outputs each line
            string[] niceDays = { "Today is the best day: ", "No This day is the best day: ", "The worst day could be: " };
            Console.WriteLine("What day resonates with you the most?");
            string day = Console.ReadLine();
            //This is part two a loop
            for (int i = 0; i < niceDays.Length; i++)
            {
                Console.WriteLine(niceDays[i] + day);
            }
            Console.ReadLine();
            //This is part 3 it loops through an integer and compares - any years less than 2000
            int[] niceYears = { 1974, 1969, 1992, 1968, 2000, 2003 };

            for (int j = 0; j < niceYears.Length; j++)
            {
                if (niceYears[j] < 2000)
                {
                    Console.WriteLine("These are the best years: " + niceYears[j]);
                }
            }
            Console.ReadLine();
        }

        { 
                //Part 4 string list with a compare and return function
            List<string> niceWords = new List<string>
            {
                "Awesome Life has never been so good.",
                "Ok just keep pushing forward.",
                "Bad could use some help."
            };
            Console.WriteLine("Type the word that best describes how you are feeling: Awesome or Ok or Bad");
            string match = (Console.ReadLine());

                //gets the index of the value of the matched word
            int indexOfValue = niceWords.FindIndex(a => a.Contains(match));
                //loops through list

            foreach (string word in niceWords)
            {
                if (word.Contains(match))
                {
                    Console.WriteLine("The feeling you chose is at index value: " + indexOfValue + " of the list.");
                    break;
                }
                    else
                    {
                        Console.WriteLine("That word is not on this line of the list. ");
                    }
            }
            Console.ReadLine();
        }
        {
            //Part 5 string with duplicates
            List<string> nicePeople = new List<string>
            {
                "Shea",
                "Abby",
                "Chris",
                "Tammy",
                "Shea",
            };

            List<string> nicerPeople = new List<string>();

            foreach (string person in nicePeople)
            { 
                if (nicerPeople.Contains(person))
                {
                        
                    Console.WriteLine("The family member " + person + " has already appeared on the list. Press enter for more.");
                        
                }
                    else
                    {
                    Console.WriteLine("The family member " + person + " has not appeared on the list. Press enter for more.");
                    nicerPeople.Add(person);
                    }
            Console.ReadLine();

            }
            
            
        }    
    }   
}

