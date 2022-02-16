using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the first line of the program the WriteLine then the following ReadLine displays to console
            Console.WriteLine("The Tech Academy.");
            Console.ReadLine();
            //Once the above statement prints the expected behavior is to press enter to see this next line
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            //Again the user will press enter and the following question will display.
            Console.WriteLine("What is your name?");
            //the output is stored first as a string value
            string myName = Console.ReadLine();
            //This is the question for the next variable
            Console.WriteLine("What course are you on?");
            //first collect the output
            string myCourse = Console.ReadLine();
            //this is the question that will need to be converted to an integer
            Console.WriteLine("What page number?");
            string myPage = Console.ReadLine();
            Int16 mypageNumber = Convert.ToInt16(myPage);
            //this is the question that will need to be converted to a boolean
            Console.WriteLine("Do you need help with anything else? Please answer \"True\" or \"False\".");
            string myHelp = Console.ReadLine();
            bool myhelpAnswer = Convert.ToBoolean(myHelp);
            //A question where the data type could be long.
            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics");
            string myPositives = Console.ReadLine();
            //Another question in the form
            Console.WriteLine("Is there any other feedback you’d like to provide ? Please be specific.");
            string myFeedback = Console.ReadLine();
            //And the last question that should be an integer
            Console.WriteLine("How many hours did you study today?");
            string myHours = Console.ReadLine();
            Int16 myhoursNow = Convert.ToInt16(myHours);
            //And this is the final line output finishing the code
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day.");
            Console.ReadLine();
        }
    }
}
