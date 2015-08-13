//Problem 1. Square root
//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.


using System;

class SquareRoot
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number:");
        try
        {
            int x = int.Parse(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                Console.WriteLine("The square root is {0:F2}", Math.Sqrt(x));
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
            //throw;
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}

