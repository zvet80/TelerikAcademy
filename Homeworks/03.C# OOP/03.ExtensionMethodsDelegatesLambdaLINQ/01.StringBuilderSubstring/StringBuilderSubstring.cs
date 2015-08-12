//Problem 1. StringBuilder.Substring
//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.


using System;
using System.Text;

namespace _01.StringBuilderSubstring
{
    class StringBuilderSubstring
    {
        static void Main()
        {
            StringBuilder x = new StringBuilder("Implement an extension method");
            StringBuilder y = x.Substring(13, 9);
            
            Console.WriteLine(y);
            //Console.WriteLine(x.Substring(-13, 9));
            //Console.WriteLine(x.Substring(25, 9));
        }
    }
}

