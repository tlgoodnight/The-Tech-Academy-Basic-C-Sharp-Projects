using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsChallenge
{
    public static class MethodsClass
    {
        public static int Method1(int result1)
        {
            //equation is how many hours a year the person sleeps.
            return result1 * 365;
        }
        
        public static int Method2(int result2)
        {
            //how many days the person sleeps in a year.
            return result2 * 365 / 24;
        }
        public static int Method3(int result3)
        {
            //this returns the usernumber of result3 times 365 days a year times 60 minutes in an hour * 60 seconds in an hour
            return (((result3 * 365) * 60) * 60);   
        }

    }
    
}
