//Problem 2. Get largest number
//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter integer x:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer y:");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer z:");
        int z = int.Parse(Console.ReadLine());

        Console.WriteLine("The max number is {0}", GetMax(x, GetMax(y, z)));
    }

    static int GetMax(int x, int y)
    {
        if (x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
}

