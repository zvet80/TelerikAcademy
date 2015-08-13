//•	Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;

class Palindromes
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string[] text = Console.ReadLine().Trim().ToLower().Split(' ');
        
        for (int i = 0; i < text.Length; i++)
        {
            bool isPal = false;
            for (int j = 0; j < text[i].Length / 2; j++)
            {
                if (text[i][j] == text[i][text[i].Length - 1 - j])
                {
                    isPal = true;
                }
            }
            if (isPal)
            {
                Console.WriteLine(text[i]);
            }            
        }
        //if (isPal==false)
        //{
        //    Console.WriteLine("no");
        //}        
    }
}
