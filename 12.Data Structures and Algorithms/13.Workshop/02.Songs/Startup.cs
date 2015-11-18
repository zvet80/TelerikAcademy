namespace _02.Songs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] own = new int[n];
            int[] official = new int[n];
            int[] rename = new int[n];
            official = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); ;
            own = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                rename[official[i] - 1] = i;
            }

            for (int i = 0; i < n; i++)
            {
                own[i] = rename[own[i] - 1];
            }

            Console.WriteLine(InvCount(own));
        }

        public static long Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, count = 0;
            while (i < left.Length || j < right.Length)
            {
                if (i == left.Length)
                {
                    arr[i + j] = right[j];
                    j++;
                }
                else if (j == right.Length)
                {
                    arr[i + j] = left[i];
                    i++;
                }
                else if (left[i] <= right[j])
                {
                    arr[i + j] = left[i];
                    i++;
                }
                else
                {
                    arr[i + j] = right[j];
                    count += left.Length - i;
                    j++;
                }
            }

            return count;
        }

        static long InvCount(int[] arr)
        {
            if (arr.Length < 2)
            {
                return 0;
            }

            int m = (arr.Length + 1) / 2;
            int[] left = new int[m];
            int[] right = new int[arr.Length - m];
            for (int i = 0; i < m; i++)
            {
                left[i] = arr[i];
            }
            for (int i = 0; i < right.Length; i++)
            {
                right[i] = arr[i + m];
            }

            return InvCount(left) + InvCount(right) + Merge(arr, left, right);
        }
    }
}
