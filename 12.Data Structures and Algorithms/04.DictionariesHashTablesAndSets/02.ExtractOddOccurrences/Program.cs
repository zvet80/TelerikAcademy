namespace _02.ExtractOddOccurrences
{
    /*2.Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. Example:
        {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}*/

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<string> list = new List<string>() { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            list = ExtractOddOccurrences(list);
            Console.WriteLine(string.Join(",", list));
        }

        public static List<string> ExtractOddOccurrences(List<string> list)
        {
            var oddCount = list
                .GroupBy(x => x)
                .Where(x => x.Count() % 2 != 0)
                .Select(x => x.Key)
                .ToList();

            return oddCount;
        }
    }
}
