//Problem 6. Divisible by 7 and 3
//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Linq;
using Students;

class DivisibleBy7And3
{
    static void Main()
    {
        var nums = new[] { 52, 6, 4, -9, 3 , 21};

        var query =
            from n in nums
            where (n % 7 == 0) && (n % 3 == 0)
            select n;
        query.ForEach(n => Console.WriteLine(n));
    }
}
