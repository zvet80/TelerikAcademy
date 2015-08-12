//Problem 5. Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7.


using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Please, enter an integer: ");
        int x = int.Parse(Console.ReadLine());
        
        bool isThird7 = ( (x / 100) % 10 == 7);
        Console.WriteLine("The third digit from right-to-left is 7: {0}", isThird7);           
    }
}

