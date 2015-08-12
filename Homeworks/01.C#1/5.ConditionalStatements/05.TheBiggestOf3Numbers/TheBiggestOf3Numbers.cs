//Problem 5. The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers.

using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter variable a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter variable b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter variable c: ");
        double c = double.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("The biggest is {0}", a);
            }
            else
            {
                Console.WriteLine("The biggest is {0}", c);
            }
        }
        else
        {
            if (b < c)
            {
                Console.WriteLine("The biggest is {0}", c);
            }
            else
            {
                Console.WriteLine("The biggest is {0}", b);
            }
        }
    }
}


