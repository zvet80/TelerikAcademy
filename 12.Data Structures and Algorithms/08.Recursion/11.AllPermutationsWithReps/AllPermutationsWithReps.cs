namespace _11.AllPermutationsWithReps
{
    using System;

    public class AllPermutationsWithReps
    {
        public static void Main()
        {
            int[] arr = { 1, 3, 5, 5 };
            PrintPermutationsNoRepetition(arr, 1);
        }

        public static void PrintPermutationsNoRepetition(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                Console.WriteLine("(" + string.Join(" ", arr) + ")");
            }
            else
            {
                PrintPermutationsNoRepetition(arr, index-1);

                for (int i = 0; i < arr.Length-1; i++)
                {
                    if (arr[i] != arr[index + 1])
                    {
                        Swap(arr, index+1, i);
                        PrintPermutationsNoRepetition(arr, index + 1);
                        Swap(arr, index+1, i);
                    }
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
