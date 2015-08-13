﻿//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;

    class CalculateSumOfFactorialsDivNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter integer number:");            
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer divider:");
            int x = int.Parse(Console.ReadLine());
            double factorial = 1;
            double sum = 1;
            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * fact;                
                sum = sum + factorial / (int)Math.Pow(x,i);
                fact++;
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }

