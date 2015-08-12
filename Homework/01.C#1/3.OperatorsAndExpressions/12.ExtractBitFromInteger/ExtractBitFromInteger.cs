//Problem 12. Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFromInteger
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
        Console.WriteLine("bit @ p: {0}",bit);
        Console.WriteLine();
    }
}

