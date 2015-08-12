//Problem 7. Calculate N! / (K! * (N-K)!)
//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.


using System;
using System.Numerics;

class CalculateFactorialExpr
{
    static void Main()
    {
        Console.WriteLine("Enter integer number n (n < 100): ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer divider k (1 < k < n): ");
        int k = int.Parse(Console.ReadLine());
        BigInteger expr;
        BigInteger factN = 1;
        BigInteger factK = 1;
        BigInteger factNK = 1;

        for (int i = 1; i <= n; i++)
        {
            factN = factN * i;

            if (i == k)
            {
                factK = factN;
            }
            if (i == (n - k))
            {
                factNK = factN;
            }
        }
        expr = (factN / (factK * factNK));
        Console.WriteLine(expr);     
    }
}

