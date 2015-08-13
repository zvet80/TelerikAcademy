//•	Write a program that reads a string, reverses it and prints the result at the console.

using System;
//using System.Text;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        char[] s = Console.ReadLine().ToCharArray();
        Array.Reverse(s);
        Console.WriteLine(s);
    }
}


//using System;
//using System.Linq;

//class ReverseString
//{
//    static void Main()
//    {
//        Console.Write("Enter a string: ");
//        string input = Console.ReadLine();
//        string reversed = string.Join("", input.Reverse());
//        Console.WriteLine("The reversed string: {0}", reversed);
//    }
//}