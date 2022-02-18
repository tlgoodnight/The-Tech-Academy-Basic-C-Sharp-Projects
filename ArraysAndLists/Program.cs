using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        // This is a string array - With user input and output. 
        string[] stringArray = new string[5];
        stringArray[0] = "This is array 0 - The beginning.";
        stringArray[1] = "This is array 1 - The saga continues.";
        stringArray[2] = "This is array 2 - Will it work?";
        stringArray[3] = "This is array 3 - At this point it must be.";
        stringArray[4] = "This is array 4 - The end.";

        //This is the opening question
        Console.WriteLine("Choose a number from 0-4 and the sentence will be revealed.");
        //This is the variable created as an integer from the output
        int arrayChoice = Convert.ToInt32(Console.ReadLine());
        //this is an if clause to display content when an index out of range is given on output.
        if (arrayChoice > 4)
            Console.WriteLine("That number is not in the index.");
        else
            Console.WriteLine(stringArray[arrayChoice]);
            Console.ReadLine();

        //2. Array of integers. 
        int[] numArray2 = { 5, 2, 10, 200, 500, 600, 2300 };
        Console.WriteLine("Choose a number from 0-6 display the integer.");
        int numChoice = Convert.ToInt32(Console.ReadLine());

        if (numChoice > 6)
            Console.WriteLine("That number is not in the index.");
        else
            Console.WriteLine(numArray2[numChoice]);
            Console.ReadLine();


        //List of string data. 
        List<string> stringList = new List<string>();
        stringList.Add("This is the start to my world.");
        stringList.Add("As I keep adding things the list gets bigger.");
        stringList.Add("I think I am going to keep this short");
        stringList.Add(" It has been a long day. ");

        Console.WriteLine("Please choose a number 0-3 to display the string in the index for the list");
        int listChoice = Convert.ToInt32(Console.ReadLine());

        if (listChoice > 3)
            Console.WriteLine("That number is not in the index.");
        else
            Console.WriteLine(stringList[listChoice]);
            Console.ReadLine();
    }
}

