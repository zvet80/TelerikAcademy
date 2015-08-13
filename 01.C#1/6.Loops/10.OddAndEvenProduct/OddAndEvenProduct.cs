//Problem 10. Odd and Even Product
//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        //Console.WriteLine("Enter a number n > 1: ");
        //int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integers, in a single line, separated by a space:");
        string[] x = Console.ReadLine().Split(' ');
        int prodOdd = 1;
        int prodEven = 1;        

        for (int i = 0; i < x.Length; i++)
        {
            int y = int.Parse(x[i]);
            if (i % 2 == 0)
            {
                prodOdd *= y;
            }
            else
            {
                prodEven *= y;
            }
        }
        if (prodEven == prodOdd)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", prodOdd);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("prod_odd = {0}\nprod_even = {1}", prodOdd, prodEven);
        }
    }
}