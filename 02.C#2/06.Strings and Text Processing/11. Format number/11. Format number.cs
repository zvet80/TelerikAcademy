/*•	Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
         * percentage and in scientific notation.
          •	Format the output aligned right in 15 symbols.*/

using System;

class FormatNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("decimal:{0,15:0.00}", x);
        Console.WriteLine("hexadecimal:{0,15:X}", (int)x);
        Console.WriteLine("hexadecimal:{0,15:P}", x/100);
        Console.WriteLine("hexadecimal:{0,15:E}", (int)x);
    }
}

