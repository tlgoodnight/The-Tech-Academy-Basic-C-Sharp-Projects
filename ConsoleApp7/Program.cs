using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //the video discussed strings These are strings we will work with in this project. 
            string fName = "Tammy";
            string lName = "Goodnight - ";
            
            string helloMsg = "\" Welcome to my universe.\" \n\t This will be a great experience!"; //this variable uses a couple different escape sequences. 

            bool trueOrFalse = fName.Contains("T");
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();
            trueOrFalse = lName.EndsWith("s");
            Console.WriteLine(trueOrFalse);
            Console.WriteLine(fName + " " + lName + " " + helloMsg);//this line concatenates three strings together.
            Console.ReadLine();

            int length = fName.Length;
            Console.WriteLine(length);
            Console.ReadLine();

            fName = fName.ToUpper();//this line converts a string to uppercase.
            Console.WriteLine(fName);
            Console.ReadLine();
            //this is using StringBuilder to build a paragraph
            StringBuilder sb = new StringBuilder();

            sb.Append("My Name is Tammy!");
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Append(" And I Love Coding! ");
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Append(" This C# Course has been the best so far. ");
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Append(" It is almost too easy. ");
            Console.WriteLine(sb);
            Console.ReadLine();

          
        }
    }
}
