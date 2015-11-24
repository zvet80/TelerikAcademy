namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection.Count <= 1)
            {
                return;
            }

            int m = (collection.Count + 1) / 2;
            IList<T> left = new List<T>(m);
            IList<T> right = new List<T>(collection.Count - m);

            for (int i = 0; i < m; i++)
            {
                left.Add(collection[i]);
            }
            for (int i = 0; i < collection.Count - m; i++)
            {
                right.Add(collection[i + m]);
            }

            Sort(left);
            Sort(right);
            Merge(collection, left, right);
        }

        public static void Merge(IList<T> collection, IList<T> left, IList<T> right)
        {
            int i = 0, j = 0;
            while (i < left.Count || j < right.Count)
            {
                if (i == left.Count)
                {
                    collection[i + j] = right[j];
                    j++;
                }
                else if (j == right.Count)
                {
                    collection[i + j] = left[i];
                    i++;
                }
                else if (left[i].CompareTo(right[j]) < 0)
                {
                    collection[i + j] = left[i];
                    i++;
                }
                else
                {
                    collection[i + j] = right[j];
                    j++;
                }
            }
        }
    }
}