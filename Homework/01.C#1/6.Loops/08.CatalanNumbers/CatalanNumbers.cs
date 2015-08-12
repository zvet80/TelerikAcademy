//Problem 8. Catalan Numbers
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula (2n)!/(n+1)!*n!
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).


using System;
using System.Numerics;


class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter integer number n (0 ≤ n ≤ 100): ");
        int n = int.Parse(Console.ReadLine());        
        BigInteger expr = 0;
        BigInteger factN = 1;
        BigInteger fact2N = 1;
        BigInteger factN1 = 1;

        if (n == 0)
        {
            Console.WriteLine(expr = 1);
        }
        else
        {
            for (int i = 1; i <= 2 * n; i++)
            {
                fact2N = fact2N * i;

                if (i == n + 1)
                {
                    factN1 = fact2N;
                }
                if (i == n)
                {
                    factN = fact2N;
                }
            }
            expr = (fact2N / (factN1 * factN));
            Console.WriteLine(expr);
        }
    }
}

