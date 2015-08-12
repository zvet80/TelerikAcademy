//•	Write a program that reads a string from the console and lists all different words in the 
//  string along with information how many times each word is found.

using System;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        Console.WriteLine("Enter string");
        string[] str = Console.ReadLine().Split(' ');
        Dictionary<string, int> letters = new Dictionary<string, int>();
        for (int i = 0; i < str.Length; i++)
        {
            if (letters.ContainsKey(str[i]))
            {
                letters[str[i]]++;
            }
            else
            {
                letters.Add(str[i], 1);
            }
        }
        foreach (var letter in letters)
        {
            Console.WriteLine("{0} - {1}", letter.Key, letter.Value);
        }
    }
}

