//Problem 12. Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.


using System;

class NullValues
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        int? x = 5 + nullInt;
        double? y = nullDouble + null;
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}

