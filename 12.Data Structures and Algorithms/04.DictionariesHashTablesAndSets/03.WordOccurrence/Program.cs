namespace _03.WordOccurrence
{
    /*Write a program that counts how many times each word from given text file words.txt appears in it. The character casing differences should be ignored. The result words should be ordered by their number of occurrences in the text. Example:

        This is the TEXT. Text, text, text – THIS TEXT! Is this the text?
        is -> 2
        the -> 2
        this -> 3
        text -> 6*/

    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string text = "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?";
            ExtractOccurrences(text);
        }

        public static void ExtractOccurrences(string text)
        {
            var occurrences = text.Split(new[] { ".", "!", "?", ",", ";", ":", "'", " ", "–" }, StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(x => x.ToLower())
                .ToDictionary(g => g.Key, g => g.Count());

            foreach (var item in occurrences)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}
