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
            //2 instantiate that class
            TestVoid t = new TestVoid();
            {
                //have user enter a number call the the method display the output
                Console.WriteLine("Please pick a number to divide by 2: ");
                int int1 = Convert.ToInt32(Console.ReadLine());
                t.result(int1);
                Console.ReadLine();
                //this is an overload method for above.
                Console.WriteLine("Please pick a number to divide by 2: ");
                int int2 = Convert.ToInt32(Console.ReadLine());
                t.result(int2);
                Console.ReadLine();

                //this is the format for an out argument example - 
                int initializeInMethod;
                t.OutArgExample(out initializeInMethod);
                Console.WriteLine(initializeInMethod);// results = 44 
                Console.ReadLine();
            }
            
            {
                //this code sets the static class Family and field(Name) to Goodnight
                Family.Name = "Goodnight";
                Console.WriteLine(Family.Name);
                Console.ReadLine();
            }
        }
    }
    
}
