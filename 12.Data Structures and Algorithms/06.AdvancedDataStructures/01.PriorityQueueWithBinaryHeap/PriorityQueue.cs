namespace _01.PriorityQueueWithBinaryHeap
{
    using System;

    /// <summary>
    /// A min-type priority queue of Binary heap, since min value has highest priority
    /// </summary>
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private T[] heap;
        private int capacity = 16;

        public PriorityQueue()
        {
            this.heap = new T[this.capacity];
        }

        public PriorityQueue(int capacity)
        {
            this.heap = new T[capacity];
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
        }

        public int Size { get; set; }

        public void Enqueue(T item)
        {
            if (this.Capacity == this.heap.Length)
            {
                this.Resize();
            }

            this.heap[this.Size] = item;
            this.UpHeap(this.Size);
            this.Size++;
        }

        public T Peek()
        {
            return this.heap[0];
        }

        public T Dequeue()
        {
            T item = this.heap[0];
            this.Size--;
            this.heap[0] = this.heap[this.Size];
            this.DownHeap(0);
            return item;
        }

        private void UpHeap(int childIndex)
        {
            if (childIndex > 0)
            {
                int parentIndex = (childIndex - 1) / 2;

                if (this.heap[childIndex].CompareTo(this.heap[parentIndex]) < 0)
                {
                    this.Swap(parentIndex, childIndex);
                    this.UpHeap(parentIndex);
                }
            }
        }

        private void DownHeap(int parentIndex)
        {
            int leftChildIndex = (2 * parentIndex) + 1;
            int rightChildIndex = leftChildIndex + 1;
            int lowestChildIndex = parentIndex;
            if (leftChildIndex < this.Size &&
                this.heap[leftChildIndex].CompareTo(this.heap[lowestChildIndex]) < 0)
            {
                lowestChildIndex = leftChildIndex;
            }

            if (rightChildIndex < this.Size &&
                this.heap[rightChildIndex].CompareTo(this.heap[lowestChildIndex]) < 0)
            {
                lowestChildIndex = rightChildIndex;
            }

            if (lowestChildIndex != parentIndex)
            {
                this.Swap(parentIndex, lowestChildIndex);
                this.DownHeap(lowestChildIndex);
            }
        }

        private void Swap(int parentIndex, int childIndex)
        {
            T valueToSwap = this.heap[parentIndex];
            this.heap[parentIndex] = this.heap[childIndex];
            this.heap[childIndex] = valueToSwap;
        }

        private void Resize()
        {
            T[] newHeap = new T[this.heap.Length * 2];
            Array.Copy(this.heap, 0, newHeap, 0, this.heap.Length);
            this.heap = newHeap;
        }
    }
}