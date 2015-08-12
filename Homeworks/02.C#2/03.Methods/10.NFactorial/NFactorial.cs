//Problem 10. N Factorial
//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        Console.WriteLine("Enter n in the range [1..100]:");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("n!= {0}",CalcFactorial(n));
    }

    private static BigInteger CalcFactorial(int n)
    {
        BigInteger factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }    
}

