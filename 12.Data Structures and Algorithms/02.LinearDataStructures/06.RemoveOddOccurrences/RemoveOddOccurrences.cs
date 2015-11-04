namespace _06.RemoveOddOccurrences
{
    /*6.Write a program that removes from given sequence all numbers that occur odd number of times.
        Example:
        {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}*/

    using System;
    using System.Collections.Generic;

    class RemoveOddOccurrences
    {
        static void Main()
        {
            List<int> list = new List<int>() { 1, 1, 5, 5, 6, 7, 8, 1, -9, 5, 5, 6, 7 };
            RemoveOddOccurred(list);
            Console.WriteLine(string.Join(",", list));
        }

        public static void RemoveOddOccurred(List<int> list)
        {
            int count;
            for (int i = 0; i < list.Count; i++)
            {
                count = 0;
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        count++;
                    }
                }

                if (count % 2 != 0)
                {
                    int num = list[i];
                    for (int k = 0; k < list.Count; k++)
                    {
                        if (list[k] == num)
                        {
                            list.RemoveAt(k);
                            k--;
                        }
                    }

                    i--;
                }
            }
        }
    }
}
