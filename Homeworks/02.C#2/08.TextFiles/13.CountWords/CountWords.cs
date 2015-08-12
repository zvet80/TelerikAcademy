//Problem 13. Count words
//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class CountWords
{
    static void Main()
    {
        try
        {
            StreamReader textReader = new StreamReader(@"..\..\test.txt");
            StreamReader wordsReader = new StreamReader(@"..\..\words.txt");
            StreamWriter fileWriter = new StreamWriter(@"..\..\result.txt");
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            string[] words = wordsReader
                            .ReadToEnd()
                            .Trim()
                            .Split(new char[] { ' ', '\n', '\t', '\r' },
                            StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                wordsCount.Add(words[i].ToLower(), 0);
            }

            using (fileWriter)
            {
                using (textReader)
                {
                    string line = textReader.ReadLine();
                    while (line != null)
                    {
                        string[] text = line.Split(' ', ',', '.');
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (wordsCount.ContainsKey(text[i].ToLower()))
                            {
                                wordsCount[text[i].ToLower()]++;
                            }
                        }
                        line = textReader.ReadLine();
                    }

                    wordsCount = wordsCount
                                .OrderByDescending(x => x.Value)
                                .ToDictionary(x => x.Key, x => x.Value);
                    foreach (var word in wordsCount)
                    {
                        fileWriter.WriteLine("{0} - {1}", word.Key, word.Value);
                    }
                }
                Console.WriteLine("ready");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}

