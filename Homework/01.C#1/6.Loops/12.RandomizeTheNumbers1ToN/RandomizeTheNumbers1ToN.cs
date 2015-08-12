//Problem 12.* Randomize the Numbers 1…N
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Collections.Generic;
using System.Linq;

class RandomizeTheNumbers1N
{
    static void Main()
    {
        Console.WriteLine("Enter integer n: ");
        int n = int.Parse(Console.ReadLine());
        Random rand = new Random();
        List<int> original = Enumerable.Range(1, n).ToList();
        List<int> sorted = original.OrderBy(item => rand.Next()).ToList();
        foreach (int i in sorted)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

