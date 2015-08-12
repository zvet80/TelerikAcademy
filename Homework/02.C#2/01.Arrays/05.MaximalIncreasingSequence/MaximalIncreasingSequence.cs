//Problem 5. Maximal increasing sequence
//Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Collections.Generic;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of integers, separated by comma:");
        int[] sequence = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
        List<int> increasingElements = new List<int>();
        List<int> max = new List<int>();
        
        for (int i = 0; i < sequence.Length; i++)
        {
            if ((i > 0) && (sequence[i] < sequence[i - 1]))
            {
                increasingElements.Clear();
                increasingElements.Add(sequence[i]);
            }
            else
            {
                increasingElements.Add(sequence[i]);
            }

            if (max.Count < increasingElements.Count)
            {
                max.Clear();
                max.AddRange(increasingElements);
            }
        }
        Console.WriteLine("Maximal increasing sequence: {0}", string.Join(",", max.ToArray()));
    }
}

