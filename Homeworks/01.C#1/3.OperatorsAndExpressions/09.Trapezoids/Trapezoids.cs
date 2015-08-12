//Problem 9. Trapezoids
//Write an expression that calculates trapezoid's area by given sides a and b and height h

using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Please enter a,b,h of trapezoid: ");
        string inputs = Console.ReadLine();
        double a = Convert.ToDouble(inputs.Split(',')[0]);
        double b = Convert.ToDouble(inputs.Split(',')[1]);
        double h = Convert.ToDouble(inputs.Split(',')[2]);
        double area = ((a + b) * h) / 2;
        Console.WriteLine("Trapezoid's area is: {0}", area);
        Console.WriteLine();
    }
}
