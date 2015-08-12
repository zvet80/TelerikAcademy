//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;

class ParseTags
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        string open = "<upcase>";
        string close = "</upcase>";
        string textToUpper = "";

        for (int i = 0; i < text.Length; i++)
        {
            if (text.IndexOf(open, i) != -1)
            {
                textToUpper = text.Substring(text.IndexOf(open, i) + open.Length, 
                    text.IndexOf(close, text.IndexOf(open, i)) - text.IndexOf(open, i) - open.Length);
                
                text = text.Replace(open+textToUpper+close, textToUpper.ToUpper());
            }
        }
        Console.WriteLine(text);
    }
}

