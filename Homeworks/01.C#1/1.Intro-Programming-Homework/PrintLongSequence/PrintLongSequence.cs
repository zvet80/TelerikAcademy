//Problem 16.* Print Long Sequence
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//You might need to learn how to use loops in C# (search in Internet).

using System;

class PrintLongSequence
{
    static bool isEven(int number)
    {
        return (number % 2 == 0);
    }

    static void Main()
    {
        int count = 1000;
        int number = 2;
        for (int i = 0; i < count; i++, number++)
        {
            Console.Write((isEven(number) ? number : -number) + ",");            
        }
    }
}
