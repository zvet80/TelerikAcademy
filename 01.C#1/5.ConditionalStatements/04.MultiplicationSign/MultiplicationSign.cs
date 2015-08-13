//Problem 4. Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.


using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter real number a: ");
        int a = Math.Sign(double.Parse(Console.ReadLine()));
        Console.Write("Enter real number b: ");
        int b = Math.Sign(double.Parse(Console.ReadLine()));
        Console.Write("Enter real number c: ");
        int c = Math.Sign(double.Parse(Console.ReadLine()));
        int sign = a + b + c;

        if (a==0 || b==0 ||c==0) Console.WriteLine(0);
        if (sign == - 1 || sign == 3) Console.WriteLine("+");
        if (sign == 1 || sign == -3) Console.WriteLine("-");
    }
}
