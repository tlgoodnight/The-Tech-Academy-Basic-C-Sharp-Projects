using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
   
    {
        List<int> nmberList = new List<int> { 100, 999, 250, 500};//List of integers
        

        Console.Write("Please choose a number to divide into the integers on the number List: ");//user input
        string numberOne = Console.ReadLine();
        foreach (int nmbr in nmberList)
            try
            {

                int numberTwo = Convert.ToInt32(numberOne);
                int result = (nmbr / numberTwo);
                Console.WriteLine(nmbr + " divided by " + numberTwo + " equals " + result);
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine(ex.Message + "Please use a whole number.");
                break;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero.");
                break;   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                break;
            }
            finally
            {
                Console.ReadLine();
            }

        Console.WriteLine("This program has finished.");
        Console.ReadLine();
        
    }
}
