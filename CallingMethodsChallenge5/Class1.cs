using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
//1. Create a class 
class TestVoid
{
    //continue of 1 - create a void method that outputs an integer.
    //have the method dive the data passed to it by 2.

    
    public void result(int int1)
    {
        int results = int1 / 2;
        Console.WriteLine(results);
    }
    //5. This is an overload method to above 
    public void result(int int2, int int3 = 2)
    {
        int results = int2 / int3;
        Console.WriteLine(results);
    }
    public void OutArgExample(out int number)
    {
        number = 44;
    }
}

