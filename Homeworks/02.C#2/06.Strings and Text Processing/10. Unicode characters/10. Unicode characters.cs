//•	Write a program that converts a string to a sequence of C# Unicode character literals.
//•	Use format strings.


using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Enter string:");
        string str = Console.ReadLine();
        StringBuilder text = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            text = text.AppendFormat("\\u{0:X4}",(int)str[i]);
        }
        Console.WriteLine(text);
    }
}

