/* •	We are given a string containing a list of forbidden words and a text containing some of 
        * these words.
          •	Write a program that replaces the forbidden words with asterisks.*/
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//Forbidden words: PHP, CLR, Microsoft
//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

using System;

class ForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter forbidden words, separated by comma:");
        string[] words = Console.ReadLine().Trim().Split(',');

        for (int i = 0; i < words.Length; i++)
        {
            if (text.IndexOf(words[i])!=-1)
            {
                text = text.Replace(words[i], new string('*', words[i].Length));
            }
        }
        Console.WriteLine(text);
    }
}

