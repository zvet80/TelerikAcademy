namespace _03.CombinationsWithoutDuplicates
{
    /*3.Modify the previous program to skip duplicates:
        n=4, k=2 → (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)*/

    using System;

    public class CombinationsWithoutDuplicates
    {
        public static void Main()
        {
            int n = 4;
            int k = 2;
            int[] arr = new int[k];

            PrintCombinationsWithoutDuplicates(arr, 0, 1, n);
        }

        public static void PrintCombinationsWithoutDuplicates(int[] arr, int index, int startNum, int n)
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
                    PrintCombinationsWithoutDuplicates(arr, index + 1, i + 1, n);
                }
            }
        }
    }
}
