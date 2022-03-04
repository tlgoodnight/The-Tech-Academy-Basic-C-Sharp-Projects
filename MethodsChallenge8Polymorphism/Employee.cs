using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee : Person, IQuitable
{
    public int Id { get; set; }

    public void Quit()
    {
        Console.WriteLine("Don't let the door hit you.");
    }

    public override void SayName()
    {
        Console.WriteLine("Name: {0} {1}", FirstName, LastName);
    }
    

}

