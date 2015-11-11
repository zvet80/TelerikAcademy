namespace _02.CombinationsWithDuplicates
{
    /*2.Write a recursive program for generating and printing all the combinations with duplicatesof k elements from n-element set. Example:
        n=3, k=2 → (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)*/

    using System;

    public class CombinationsWithDuplicates
    {
        public static void Main()
        {
            int n = 3;
            int k = 2;
            int[] arr = new int[k];

            PrintCombinationsWithDuplicates(arr, 0, 1, n);
        }

        public static void PrintCombinationsWithDuplicates(int[] arr, int index, int startNum, int n)
        {
            if (index == arr.Length)
            {
                Console.WriteLine("(" + string.Join(" ", arr) + ")");
            }
            else
            {
                for (int i = startNum; i <= n; i++)
                {
                    arr[index] = i;
                    PrintCombinationsWithDuplicates(arr, index + 1, i, n);
                }
            }
        }
    }
}
