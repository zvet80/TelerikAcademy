//Problem 13. Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Please, enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter an index: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        bool result = (bit == 1);
        Console.WriteLine("bit @ p == 1: {0}", result);
        Console.WriteLine();

    }
}

