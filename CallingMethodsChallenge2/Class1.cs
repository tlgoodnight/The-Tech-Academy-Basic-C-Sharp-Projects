using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsChallenge
{
    public static class MethodsClass
    {
        public static int Method1(int result1)//the first method as an integer.
        {
            //equation is how many hours a year the person sleeps.
            return result1 * 365;
        }
        
        public static decimal Method1(decimal result2)//second method as decimal
        {
            //How much is a gallon of gas in your area? Price per gallon (decimal) times 20 (average gallons in a tank) returned as integer.
            int result3 = Convert.ToInt32((result2 * 20));//return result as integer.
            return result3;
        }
        public static string Method1(string result3)
        {
            //converts the string of hours per week to integer - performs calculation- returns integer then converts to string.
            int result4 = (Convert.ToInt32(result3) * 52);
            return (Convert.ToString(result4));
        }

    }
    
}
