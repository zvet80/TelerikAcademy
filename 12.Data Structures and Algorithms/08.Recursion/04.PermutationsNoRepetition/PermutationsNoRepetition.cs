namespace _04.PermutationsNoRepetition
{
    /*Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for given integer number n. Example:
        n=3 → {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}*/

    using System;

    public class PermutationsNoRepetition
    {
        public static void Main()
        {
            int n = 3;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }

            PrintPermutationsNoRepetition(arr, 0);
        }

        public static void PrintPermutationsNoRepetition(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                Console.WriteLine("(" + string.Join(" ", arr) + ")");
            }
            else
            {
                for (int i = index; i < arr.Length; i++)
                {                    
                    Swap(arr, index, i);
                    PrintPermutationsNoRepetition(arr, index + 1);
                    Swap(arr, index, i);
                }
            }
        }

        public static void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
