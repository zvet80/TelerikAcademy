//Problem 8. Isosceles Triangle
//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//  © ©
// ©   ©
//© © © ©
//Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.


using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char s1 = '\u00a9';

        Console.WriteLine("   {0}", s1);
        Console.WriteLine("  {0} {0}", s1);
        Console.WriteLine(" {0}   {0}", s1);
        Console.WriteLine("{0} {0} {0} {0}", s1);
    }
}


