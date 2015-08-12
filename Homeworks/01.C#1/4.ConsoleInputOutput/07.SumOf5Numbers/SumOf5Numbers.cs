//Problem 7. Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers (given in a single line, separated by a space): a b c d e");
        string inputs = Console.ReadLine();
        double a = Convert.ToDouble(inputs.Split(' ')[0]);
        double b = Convert.ToDouble(inputs.Split(' ')[1]);
        double c = Convert.ToDouble(inputs.Split(' ')[2]);
        double d = Convert.ToDouble(inputs.Split(' ')[3]);
        double e = Convert.ToDouble(inputs.Split(' ')[4]);
        double sum = a + b + c + d + e;
        Console.WriteLine("sum = {0}", sum);        
    }
}

