namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (items[i].CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            int left = 0;
            int right = this.items.Count;
            int mid;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if (this.items[mid].CompareTo(item) < 0)
                {
                    left = mid + 1;
                    continue;
                }
                else if (this.items[mid].CompareTo(item) > 0)
                {
                    right = mid - 1;
                    continue;
                }
                else if (this.items[mid].CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        //Complexity O(n)
        public void Shuffle()
        {
            var random = new Random();

            for (int i = 0; i < this.items.Count; i++)
            {
                int j = random.Next(i, this.items.Count);
                T temp = this.items[i];
                this.items[i] = this.items[j];
                this.items[j] = temp;
            }

        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
