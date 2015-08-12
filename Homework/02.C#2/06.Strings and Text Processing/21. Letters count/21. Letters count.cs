//•	Write a program that reads a string from the console and prints all different letters in the 
//  string along with information how many times each letter is found.

using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        Console.WriteLine("Enter string");
        string str = Console.ReadLine();
        Dictionary<char, int> letters = new Dictionary<char, int>();
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
            Console.WriteLine("{0} - {1}",letter.Key,letter.Value);
        }
    }
}

