//Problem 10. Fibonacci Numbers
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number n: ");
        int n = int.Parse(Console.ReadLine());
        int fib0 = 0;
        int fib1 = 1;        

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0}, ", fib0);
            
            int fib2 = fib0 + fib1;
            fib0 = fib1;
            fib1 = fib2;
        }        
    }
}

