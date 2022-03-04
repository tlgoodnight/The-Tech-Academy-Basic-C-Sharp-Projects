using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee : Person
{
    public int Id { get; set; }

    public override void SayName()
    {
        Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        Console.ReadLine();
    }
}

