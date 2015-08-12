//Problem 3. English digit
//Write a method that returns the last digit of given integer as an English word.

using System;

class EnglishDigit
{
    static void Main()
    {
        Console.WriteLine("Enter an integer x: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("The last digit of {0} is {1}", x, ReturnDigitWord(x));
    }

    private static string ReturnDigitWord(int x)
    {
        int digit = x % 10;
        switch (digit)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: return "no such digit";
        }
    }
}

