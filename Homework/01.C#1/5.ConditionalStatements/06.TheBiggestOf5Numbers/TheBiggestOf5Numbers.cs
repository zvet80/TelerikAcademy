//Problem 6. The Biggest of Five Numbers
//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter a number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter a number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter a number c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter a number d: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter a number e: ");
        double e = double.Parse(Console.ReadLine());
        double maxNum = a;

        if (maxNum < b)
        {
            maxNum = b;
        }
        if (maxNum < c)
        {
            maxNum = c;
        }
        if (maxNum < d)
        {
            maxNum = d;
        }
        if (maxNum < e)
        {
            maxNum = e;
        }
        Console.WriteLine(maxNum);
    }
}

