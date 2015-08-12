//•	Write a program that reverses the words in given sentence.

using System;
//using System.Linq;

class ReverseSentence
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence");
        string text = Console.ReadLine();
        string[] words = text.Substring(0, text.Length - 1).Split(new char[] { ' ', ',' });
        Array.Reverse(words);
        Console.WriteLine(string.Join(" ", words)+text[text.Length-1]);
    }
}

