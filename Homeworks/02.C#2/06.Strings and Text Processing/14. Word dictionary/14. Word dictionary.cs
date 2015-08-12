/*•	A dictionary is stored as a sequence of text lines containing words and 
         * their explanations.
          •	Write a program that enters a word and translates it by using the dictionary.*/

using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();
        Dictionary<string,string> myDictionary= new Dictionary<string,string>();

        myDictionary.Add(".NET", "platform for applications from Microsoft");
        myDictionary.Add("CLR", "managed execution environment for .NET");
        myDictionary.Add("namespace", "hierarchical organization of classes");
        if (myDictionary.ContainsKey(word))
        {
            Console.WriteLine(myDictionary[word]);
        }
        else
        {
            Console.WriteLine("the dictionary has no explanation for this word");
        }
    }
}
