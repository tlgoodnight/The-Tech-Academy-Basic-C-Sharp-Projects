﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    public string FirstName;
    public string LastName;

    public void SayName()
    {
         Console.WriteLine("Name: {0} {1}", FirstName, LastName);
    }
}        
