using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsChallenge6
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Id = 1;
          
            Employee employee1 = new Employee();
            employee1.FirstName = "Second";
            employee1.LastName = "Student";
            employee1.Id = 1;
            

            employee.SayName();
            Console.ReadLine();
            
            employee1.SayName();
            Console.ReadLine();

            if (employee.Id == employee1.Id)
            {
                Console.WriteLine("The employee id for the two employees is equal or the same");
            }
            else 
                {
                    Console.WriteLine("The employee id for the two employees is not equal or the same");
                }
            Console.ReadLine();

            IQuitable quitable = new Employee();           
            quitable.Quit();
            Console.ReadLine();
        }
    }
}
