//Problem 6. Four-Digit Number
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Please, enter a four digit integer: ");
        int x = int.Parse(Console.ReadLine());

        int d1 = x / 1000;
        int d2 = (x % 1000) / 100;
        int d3 = (x % 100) / 10;
        int d4 = x % 10;
        Console.WriteLine(d1+d2+d3+d4);
        Console.WriteLine("{0}{1}{2}{3}",d4,d3,d2,d1);
        Console.WriteLine("{0}{1}{2}{3}", d4, d2, d3, d1);
        Console.WriteLine("{0}{1}{2}{3}", d1, d3, d2, d4);
        Console.WriteLine();
    }
}

