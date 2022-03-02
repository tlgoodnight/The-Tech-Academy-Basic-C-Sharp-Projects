using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many hours a day do you sleep?");
            int result1 = MethodsClass.Method1(Convert.ToInt32(Console.ReadLine()));//calls class and method. 
            Console.WriteLine("You sleep approximately " + result1 + " hours per year.");
            Console.ReadLine();

            Console.WriteLine("How much is a gallon of gas in your area?");
            decimal result2 = MethodsClass.Method1(Convert.ToDecimal(Console.ReadLine()));//calls class and method
            Console.WriteLine("It costs approximately $" + result2 + " to fill up your tank.");
            Console.ReadLine();

            Console.WriteLine("How many hours week do you work?");
            string result3 = MethodsClass.Method1(Console.ReadLine());//calls class and method
            Console.WriteLine("You work approximately " + result3 + " total days in a year");
            Console.ReadLine();
        }
    }
}
