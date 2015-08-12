//Problem 8. Prime Number Check
//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Please, enter a positive integer n (n <= 100): ");
        int n = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (n < 2) isPrime = false;
        if (n == 2) isPrime = true;        
        for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) isPrime = false;                
            }

        Console.WriteLine("The number is prime? {0}", isPrime);
        Console.WriteLine();
    }
}

