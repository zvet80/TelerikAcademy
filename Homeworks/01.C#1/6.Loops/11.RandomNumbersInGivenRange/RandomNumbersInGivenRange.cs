//Problem 11. Random Numbers in Given Range
//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Enter integer n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer number min: ");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer number max: ");
        int max = int.Parse(Console.ReadLine());
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.Write(" " + rand.Next(min, max));
        }
        Console.WriteLine();
    }
}

