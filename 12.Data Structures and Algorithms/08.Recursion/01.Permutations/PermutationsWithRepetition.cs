namespace _01.PermutationsWithRepetition
{
    /*1.Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.

            Examples:
                     1 1
            n=2  ->  1 2
                     2 1
                     2 2

                     1 1 1
                     1 1 2
                     1 1 3
                     1 2 1
            n=3  ->  ...
                     3 2 3
                     3 3 1
                     3 3 2
                     3 3 3 */

    using System;

    public class PermutationsWithRepetition
    {
        public static void Main()
        {
            int n = 2;
            int[] arr = new int[n];

            PrintPermutations(arr, 0, n);
        }

        public static void PrintPermutations(int[] arr, int index, int n)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    arr[index] = i;
                    PrintPermutations(arr, index + 1, n);
                }
            }
        }
    }
}
