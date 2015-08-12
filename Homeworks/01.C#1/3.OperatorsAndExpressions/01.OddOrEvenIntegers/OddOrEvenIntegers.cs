//Problem 1. Odd or Even Integers
//Write an expression that checks if given integer is odd or even.


using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Please, enter a number to check if it is odd or even: ");
        int x = int.Parse(Console.ReadLine());
        bool isEven = (x % 2 == 0);
        if (isEven == true) Console.WriteLine("{0} is even", x);
        else Console.WriteLine("{0} is odd", x);        
    }    
}

