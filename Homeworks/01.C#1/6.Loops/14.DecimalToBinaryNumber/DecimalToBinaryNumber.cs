//Problem 14. Decimal to Binary Number
//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        long x = long.Parse(Console.ReadLine());
        string digit = "";
        if (x == 0) digit = "0";

        while (x != 0)
        {
            if (x % 2 == 0)
            {
                digit = "0" + digit;
            }
            else
            {
                digit = "1" + digit;
            }
            x = x / 2;
        }
        Console.WriteLine(digit);
    }
}

