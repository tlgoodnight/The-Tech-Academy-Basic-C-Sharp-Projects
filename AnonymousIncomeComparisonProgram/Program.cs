using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro statement
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            //Statement identifying the person answering.
            Console.WriteLine("Person 1 - Please Answer the following questions: ");
            Console.ReadLine();
            //Person 1 hourly rate input and variable
            Console.WriteLine("Person 1 - What is your hourly rate?");
            string p1Rate = Console.ReadLine();
            decimal p1Rateconverted = Convert.ToDecimal(p1Rate);
            //Person 1 How many hours a week input and variable
            Console.WriteLine(" Person 1 -How many hours do you work a week?");
            string p1Hours = Console.ReadLine();
            int p1Hoursconverted = Convert.ToInt16(p1Hours);
            //Introduction to Person 2
            Console.WriteLine("Person 2 - Please Answer the following questions: ");
            Console.ReadLine();
            //Person 2 hourly rate input and variable
            Console.WriteLine("Person 2 - What is your hourly rate?");
            string p2Rate = Console.ReadLine();
            decimal p2Rateconverted = Convert.ToDecimal(p2Rate);
            //Person 2 How many hours a week input and variable
            Console.WriteLine("Person 2 - How many hours do you work a week?");
            string p2Hours = Console.ReadLine();
            int p2Hoursconverted = Convert.ToInt16(p2Hours);
            //Calculations for Annual Salary (Rate of Pay times Hours per week times 52 weeks in a year)
            decimal p1Annual = p1Rateconverted * p1Hoursconverted * 52;
            decimal p2Annual = p2Rateconverted * p2Hoursconverted * 52;
            Console.WriteLine("The Annual Salary of Person 1: " + p1Annual);
            Console.ReadLine();
            Console.WriteLine("The Annual Salary of Person 2: " + p2Annual);
            Console.ReadLine();
            //my bool comparison 
            bool myComparison = p1Annual > p2Annual;
            Console.WriteLine("Does Person 1 make more money than Person 2? True or False : " + myComparison);
            Console.ReadLine();
        }
    }
}
