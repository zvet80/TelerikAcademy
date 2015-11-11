namespace _05.VariationsWithReps
{
    /*5.Write a recursive program for generating and printing all ordered k-element subsets from n-element set(variations Vkn).
        Example: n=3, k=2, set = {hi, a, b
        } → (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)*/

    using System;

    public class VariationsWithReps
    {
        public static void Main()
        {
            int k = 2;
            string[] set = { "hi", "a", "b" };
            string[] arr = new string[k];

            PrintVariationsWithReps(arr, set, 0);
        }

        public static void PrintVariationsWithReps(string[] arr, string[] set, int index)
        {
            if (index == arr.Length)
            {
                Console.WriteLine("(" + string.Join(" ", arr) + ")");
            }
            else
            {
                foreach (var item in set)
                {
                    arr[index] = item;
                    PrintVariationsWithReps(arr, set, index + 1);
                }
            }
        }
    }
}
