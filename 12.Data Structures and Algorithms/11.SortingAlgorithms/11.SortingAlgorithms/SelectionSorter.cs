namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            int min;
            for (int i = 0; i < collection.Count; i++)
            {
                min = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[min]) < 0)
                    {
                        min = j;
                    }
                }

                Swap(collection, i, min);
            }
        }

        private void Swap(IList<T> collection, int x, int y)
        {
            T temp = collection[x];
            collection[x] = collection[y];
            collection[y] = temp;
        }
    }
}
