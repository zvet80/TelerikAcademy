//Problem 1. Sum of 3 Numbers
//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 3 real numbers: a,b,c");        
        string inputs = Console.ReadLine();
        double a = Convert.ToDouble(inputs.Split(',')[0]);
        double b = Convert.ToDouble(inputs.Split(',')[1]);
        double c = Convert.ToDouble(inputs.Split(',')[2]);
        double sum = a + b + c;
        Console.WriteLine("sum = {0}", sum);        
    }
}

