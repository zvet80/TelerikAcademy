//Problem 9. Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

using System;

class SumOfnNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers", n);
        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("sum = {0}",sum);
    }
}

