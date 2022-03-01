using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsChallenge
{
    public static class MethodsClass
    {
        public static int Method1()
        {
            Console.WriteLine("What year were you born?");
            int age = Convert.ToInt32(Console.ReadLine());
            return  2022 - age;
        }
        
        public static int Method2()
        {
            Console.WriteLine("How many hours a day do you sleep?");
            int sleep = Convert.ToInt32(Console.ReadLine());
            return sleep * 365;
        }
        public static int Method3()
        {
            Console.WriteLine("Lets figure out the square feet of your room. Please provide the following information");
            Console.WriteLine("What is the Length of the room in feet.");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the width of the room in feet.");
            int width = Convert.ToInt32(Console.ReadLine());
            return length * width;  
        }

    }
    
}
