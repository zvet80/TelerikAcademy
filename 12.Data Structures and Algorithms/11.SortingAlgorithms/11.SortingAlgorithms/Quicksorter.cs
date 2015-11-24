namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            QuickSort(collection, 0, collection.Count - 1);
        }

        private void QuickSort(IList<T> collection, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(collection, start, end);

                QuickSort(collection, start, i - 1);
                QuickSort(collection, i + 1, end);
            }
        }

        private int Partition(IList<T> collection, int start, int end)
        {
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (collection[j].CompareTo(collection[end]) < 0)
                {
                    i++;
                    Swap(collection, i, j);
                }
            }

            Swap(collection, i + 1, end);
            return i + 1;
        }

        private void Swap(IList<T> collection, int x, int y)
        {
            T temp = collection[x];
            collection[x] = collection[y];
            collection[y] = temp;
        }
    }
}
