namespace _05.ZigZag
{
    using System;
    using System.Linq;

    class Program
    {
        static int count = 0;

        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int k = input[1];
            int[] arr = new int[k];
            bool[] used = new bool[n];

            GenVariationsNoReps(0, arr, used);
            Console.WriteLine(count);
        }

        static void GenVariationsNoReps(int index, int[] arr, bool[] used)
        {
            if (index == arr.Length)
            {
                //Console.WriteLine(string.Join(",", arr));
                count++;
            }
            else
            {
                for (int i = 0; i < used.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        arr[index] = i;
                        if (IsZigZag(index, arr))
                        {
                            used[i] = false;
                            continue;
                        }

                        GenVariationsNoReps(index + 1, arr, used);
                        used[i] = false;
                    }
                }
            }            
        }

        private static bool IsZigZag(int index, int[] arr)
        {
            return index > 0 && ((index % 2 == 0 && arr[index] > arr[index - 1]) ||
                            (index % 2 != 0 && arr[index] < arr[index - 1]));
        }
    }
}
