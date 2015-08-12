//• Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;

class SubStringInText
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine().ToLower();
        Console.WriteLine("Enter text to search:");
        string s = Console.ReadLine().ToLower();
        int count = 0;


        for (int i = 0; i < text.Length; i++)
        {
            if (text.IndexOf(s, i) != -1)
            {
                count++;
                i = text.IndexOf(s, i);
            }
        }
        Console.WriteLine("The sub-string {0} is contained in the given text {1} times", s, count);
    }
}

