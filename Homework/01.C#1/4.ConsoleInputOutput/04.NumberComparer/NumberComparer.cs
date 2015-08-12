//Problem 4. Number Comparer
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter number x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter number y: ");
        double y = double.Parse(Console.ReadLine());
        double isGreater = Math.Max(x,y);        
        Console.WriteLine(isGreater);
    }
}

