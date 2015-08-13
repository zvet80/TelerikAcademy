//•	Write a program for extracting all email addresses from given text.
//•	All sub-strings that match the format @… should be recognized as emails.

using System;

class ExtractEMails
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string[] text = Console.ReadLine().Split(new char[] { ',', ' ' });
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Contains("@"))
            {
                Console.WriteLine(text[i]);
            }
        }

    }
}

