//Problem 14. Modify a Bit at Given Position
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.


using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Please, enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter an index: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter a bit value: ");
        int bit = int.Parse(Console.ReadLine());

        if (bit == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;

            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine(result);
        }
        else
        {
            int mask = 1 << p;
            int result = n | mask;

            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine(result);
        }
    }
}

