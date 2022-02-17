using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApprovalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //First question and the variable from the input of the user myAge then convert it to an integer for comparison later.
            Console.WriteLine("What is your age?");
            string myAge = Console.ReadLine();
            int myAge1 = Convert.ToInt32(myAge);
            //Second Question and convert to a boolean
            Console.WriteLine("Have you ever had a DUI? True or False ");
            string myDui = Console.ReadLine();
            bool myDui1 = Convert.ToBoolean(myDui);
            //Third Question and convert to integer 
            Console.WriteLine("How many speeding tickets do you have?");
            string myTickets = Console.ReadLine();
            int myTickets1 = Convert.ToInt32(myTickets);
            //The qualifications are 
            //Applicant must be over 15 myAge1 >15
            //Applicant must not have any Duis myDui1 == false
            //Applicant must not have more than 3 speeding tickets. 
            bool qualified = (myAge1 > 15 && myDui1 == false && myTickets1 <= 3);
            Console.WriteLine("Are you qualified for insurance? " + qualified);
            Console.ReadLine();
        }
    }
}
