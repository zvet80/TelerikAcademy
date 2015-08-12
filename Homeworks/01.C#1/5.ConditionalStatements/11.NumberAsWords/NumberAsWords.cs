//Problem 11.* Number as Words
//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

class NumberAsWords
{
    static void Main()
    {
        Console.Write("Enter a number in the range [0…999]: ");
        int number = int.Parse(Console.ReadLine());
        int digit = number % 10;

        int teen = number % 100;
        int hundred = number / 100;

        if (number / 10 == 0)
        {
            Console.WriteLine("the number is: {0}", digit);
        }

        if (hundred == 0)
        {
            if (number % 100 / 10 == 1)
            {
                Console.WriteLine("the number is: {0}", teen);
            }
            else
            {

                int ty = teen;
                if (digit == 0) Console.WriteLine("the number is: {0}", ty);
                else Console.WriteLine("the number is: {0}{1}", ty, digit);

                //    }
                //    if (teen / 10 == 1)
                //    {
                //        Console.WriteLine("the number is: ");
                //    }
                //}
            }
        }

        switch (digit)
        {
            case 0: Console.Write("zero"); break;
            case 1: Console.Write("one"); break;
            case 2: Console.Write("two"); break;
            case 3: Console.Write("three"); break;
            case 4: Console.Write("four"); break;
            case 5: Console.Write("five"); break;
            case 6: Console.Write("six"); break;
            case 7: Console.Write("seven"); break;
            case 8: Console.Write("eight"); break;
            case 9: Console.Write("nine"); break;
        }
        switch (teen)
        {
            case 10: Console.Write("ten"); break;
            case 11: Console.Write("one"); break;
            case 12: Console.Write("two"); break;
            case 13: Console.Write("three"); break;
            case 14: Console.Write("four"); break;
            case 15: Console.Write("five"); break;
            case 16: Console.Write("six"); break;
            case 17: Console.Write("seven"); break;
            case 18: Console.Write("eight"); break;
            case 19: Console.Write("nine"); break;
        }
        switch (ty)
        {
            
            case 20: Console.Write("twenty"); break;
            case 30: Console.Write("thirty"); break;
            case 40: Console.Write("fourty"); break;
            case 50: Console.Write("fifty"); break;
            case 60: Console.Write("sixty"); break;
            case 70: Console.Write("seventy"); break;
            case 80: Console.Write("eighty"); break;
            case 90: Console.Write("ninety"); break;
        }

       
    }       
}
