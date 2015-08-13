//Problem 17.* Calculate GCD
//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

using System;

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("Enter integer number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer number b: ");
        int b = int.Parse(Console.ReadLine());
        int r = 0;
        if (b > a)
        {
            a = a - b;
            b = a + b;
            a = b - a;
        }

        while (true)
        {
            a/b
        }
    }
}

