//Problem 12. Index of letters
//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {
        Console.WriteLine("Write a word:");
        string word = Console.ReadLine().ToUpper();
        int n = 'Z' - 'A';
        string[] arr = new string[n + 1];
        int j = 0;
        
        for (int i = 'A'; i <= 'Z'; i++)
        {
            arr[j] = ((char)i).ToString();
            j++;
        }
        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine(Array.IndexOf(arr, word[i].ToString()));            
        }
    }
}

