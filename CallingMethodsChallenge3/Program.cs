﻿using System;
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
            MethodsClass methods = new MethodsClass();
            
            Console.WriteLine("How many hours a day do you work?");
            int result1 = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("How many days a week do you work? This is optional. \n As per National average the default is set to 5 days a week");
            int result2 = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(methods.Method1(result1, result2));
            Console.ReadLine();
        }
    }
}