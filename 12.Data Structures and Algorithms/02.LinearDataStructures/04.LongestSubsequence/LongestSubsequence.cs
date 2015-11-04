namespace _04.LongestSubsequence
{
    /*4.Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.
      Write a program to test whether the method works correctly.*/

    using System;
    using System.Collections.Generic;

    public class LongestSubsequence
    {
        static void Main()
        {
            List<int> list = new List<int>() { 1, 9, 5, 5, 6, 7, 7, 7, 8 };

            Console.WriteLine("Maximal equal sequence: {0}",
                string.Join(",", FindLongestSubsequence(list)));
        }

        public static List<int> FindLongestSubsequence(List<int> list)
        {
            List<int> equalElements = new List<int>();
            List<int> max = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i > 0 && list[i] == list[i - 1])
                {
                    equalElements.Add(list[i]);
                }
                else
                {
                    equalElements.Clear();
                    equalElements.Add(list[i]);
                }

                if (max.Count < equalElements.Count)
                {
                    max.Clear();
                    max.AddRange(equalElements);
                }
            }

            return max;
        }
    }
}
