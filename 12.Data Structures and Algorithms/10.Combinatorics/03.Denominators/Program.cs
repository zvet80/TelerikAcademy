namespace _03.Denominators
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        private static List<int> output = new List<int>();
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            GetPermutationsNoRep(output, numbers, 0);
            output.Sort();
            Console.WriteLine(GetMinDivNum(output));
        }

        public static int GetMinDivNum(List<int> output)
        {            
            int minCount = int.MaxValue;
            int minNum = 0;

            foreach (var num in output)
            {
                int count = 0;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }

                if (minCount > count)
                {
                    minCount = count;
                    minNum = num;
                }
                
            }

            return minNum;
        }

        public static void GetPermutationsNoRep(List<int> output, int[] arr, int index)
        {
            output.Add(GetNumber(arr));

            for (int left = arr.Length - 2; left >= index; left--)
            {
                for (int right = left + 1; right < arr.Length; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        Swap(arr, left, right);
                        GetPermutationsNoRep(output, arr, left + 1);
                    }
                }

                // Undo all modifications done by recursive calls and swapping
                var firstElement = arr[left];
                for (int i = left; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[arr.Length - 1] = firstElement;
            }
        }

        public static void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        public static int GetNumber(int[] arr)
        {
            int number = 0;
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                number += (int)Math.Pow(10, len - 1 - i) * arr[i];
            }

            return number;
        }
    }
}
