//Problem 2. Enter numbers
//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100


using System;

class EnterNumbers
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        for (int i = 0; i < 10; i++)
        {
            start = ReadNumber(start, end);
        }
    }
    static int ReadNumber(int start, int end)
    {
        Console.WriteLine("Enter a number between {0}-{1}", start, end);
        int x = 0;
        try
        {
            x = int.Parse(Console.ReadLine());
            if (x < start || x > end)
            {
                Console.WriteLine("Invalid number");
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
            throw;

        }
        return x;
    }
}

