namespace _06.VariationsNoReps
{
    /*6.Write a program for generating and printing all subsets of k strings from given set of strings.
        Example: s = {test, rock, fun}, k=2 → (test rock), (test fun), (rock fun)*/

    using System;

    public class VariationsNoReps
    {
        public static void Main()
        {
            int k = 2;
            string[] set = { "test", "rock", "fun" };
            string[] arr = new string[k];

            PrintVariationsNoReps(arr, set, 0, 0);
        }

        public static void PrintVariationsNoReps(string[] arr, string[] set, int index, int start)
        {
            if (index == arr.Length)
            {
                Console.WriteLine("(" + string.Join(" ", arr) + ")");
            }
            else
            {
                for (int i = start; i < set.Length; i++)
                {
                    arr[index] = set[i];
                    PrintVariationsNoReps(arr, set, index + 1, i + 1);
                }
            }
        }
    }
}
