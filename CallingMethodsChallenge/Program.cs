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
            int result1 = MethodsClass.Method1();
            Console.WriteLine("Your current age is " + result1);
            Console.ReadLine();


            int result2 = MethodsClass.Method2();
            Console.WriteLine("You sleep approximately " + result2 + " hours per year.");
            Console.ReadLine();

            int result3 = MethodsClass.Method3();
            Console.WriteLine("Your room is approximately " + result3 + " square feet.");
            Console.ReadLine();
        }
    }
}
