//Problem 1. Exchange If Greater
//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter variable a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter variable b: ");
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            b = b - a;
            a = a + b;
            b = a - b;
        }
        Console.WriteLine("{0} {1}", a, b);        
    }
}

 