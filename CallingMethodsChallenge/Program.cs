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
            Console.WriteLine("Please provie how many hours of sleep you get on average a night?");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            int result1 = MethodsClass.Method1(userNumber);
            Console.WriteLine("You sleep approximately " + result1 + " hours per year.");
            Console.ReadLine();

            int result2 = MethodsClass.Method2(userNumber);
            Console.WriteLine("You sleep a total of " + result2 + " days a year");
            Console.ReadLine();

            int result3 = MethodsClass.Method3(userNumber);
            Console.WriteLine("You sleep approximately " + result3 + " seconds in a year.");
            Console.ReadLine();
        }
    }
}
