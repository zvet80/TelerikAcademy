//Problem 8. Extract sentences
//Write a program that extracts from a given text all sentences containing given word.
//Example:
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;

class ExtractSentences
{
    static void Main()
    {
        Console.WriteLine("Enter sentences:");
        string[] text = Console.ReadLine().Trim().Split('.');
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            string[] words = text[i].Split(new char[] { ',', ' ' });
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j] == word)
                {
                    Console.Write(text[i]+"."); break;
                } 
            }    
        }
        Console.WriteLine();
    }
}

