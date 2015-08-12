//Problem 3. Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.


using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Please, enter a number: ");
        int x = int.Parse(Console.ReadLine());
        bool div = (x % 5 == 0) && (x % 7 == 0);
        if (div == true) 
          Console.WriteLine("{0} can be divided (without remainder)" + 
                            "by 7 and 5 at the same time", x);
        else
          Console.WriteLine("{0} can not be divided (without remainder)" +
                            "by 7 and 5 at the same time", x);
        Console.WriteLine();
    }
}

