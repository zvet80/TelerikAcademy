namespace _03.WordOccurrencesInTrie
{
    /*3.Write a program that finds a set of words (e.g. 1000 words) in a large text (e.g. 100 MB text file).
        Print how many times each word occurs in the text.
        Hint: you may find a C# trie in Internet.*/

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Trie;

    public class Startup
    {
        private static char[] delimiters = { ' ', '.', ',', ';', '\'', '-', ':', '!', '?', '(', ')', '<', '>', '=', '*', '/', '[', ']', '{', '}', '\\', '"', '\r', '\n' };

        public static void Main()
        {
            var reader = new StreamReader(@"..\..\text.txt");

            using (reader)
            {
                var line = reader.ReadLine();
                List<string> allWords = new List<string>();
                
                while (line != null)
                {
                    var words = line
                                .ToLower()
                                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                                .ToList();
                    allWords.AddRange(words);
                    line = reader.ReadLine();
                }

                var trie = TrieFactory.CreateTrie();

                foreach (var word in allWords)
                {
                    trie.AddWord(word);
                }

                var rand = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    var currentWord = allWords[rand.Next(0, allWords.Count)];
                    Console.WriteLine("{0}->{1}", currentWord, trie.WordCount(currentWord));
                }
            }
        }
    }
}
