﻿//Problem 13.* Comparing Floats
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Please, enter a real number: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please, enter another real number: ");
        double y = double.Parse(Console.ReadLine());
        double eps = 0.000001;

        bool isEqual = (Math.Abs(x - y) < eps);              
        Console.WriteLine("x = y is {0}",isEqual);
    }
}

