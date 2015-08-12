//Problem 8. Binary short
//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinaryShort
{
    static void Main()
    {
        Console.WriteLine("Enter a number of type short");
        short x = short.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(x, 2));
    }
}

