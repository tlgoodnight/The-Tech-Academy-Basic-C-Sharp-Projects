using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Text
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();
            //User input for package weight variable converted to an integer.
            Console.WriteLine("What is the package weight?");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            //first if statement if pkgweight is greater than 50 return line below
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heave to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            //second step - if the total(addition) of Width/Heighth/Length is greater 50 display
            Console.WriteLine("What is the Package Width? ");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the Package Height?");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the Package Length?");
            int pkgLength = Convert.ToInt32(Console.ReadLine());
            if ((pkgWidth + pkgHeight + pkgLength) > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
                Console.ReadLine();
            }
            //complete the final calculation (Multiply the three dimensions then take the product (result) of that and multiply it by the weight and then divide that total by 100 to get quote.
            int pkgEstimate = (((pkgHeight * pkgWidth * pkgLength) * pkgWeight) / 100) ;
            {
                Console.WriteLine("Your estimated total for shipping this package is: " + "$" + pkgEstimate);
            }
            Console.ReadLine();
        }
    }
}
