namespace _05.RemoveNegative
{
    //5.Write a program that removes from given sequence all negative numbers.

    using System;
    using System.Collections.Generic;

    class RemoveNegative
    {
        static void Main()
        {
            List<int> list = new List<int>() { 1, -9, 5, 5, 6, 7, -7, 78, 8, 1, -9, 5, 5, 6, 7, -7, 78, 8, 1, -9, 5, 5, 6, 7, -7, 78, 8, 1, -9, 5, 5, 6, 7, -7, 78, 8, 1, -9, 5, 5, 6, 7, -7, 78, 8, 1, -9, 5, 5, 6, 7, -7, 78, 8, 1, -9 };
            RemoveNegativeNumbersList(list);
            Console.WriteLine("List with removed negative numbers: {0}",
                string.Join(",", list));
        }

        public static void RemoveNegativeNumbersList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                }
            }
        }
    }
}
