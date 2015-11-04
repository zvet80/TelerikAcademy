namespace _12.AutoResizableStack
{
    using System;

    public class MyStack<T>
    {
        private int capacity = 4;
        private T[] stack;

        public MyStack()
        {
            this.stack = new T[this.capacity];
            this.Count = 0;
        }

        public int Count { get; set; }

        public int Capacity
        {
            get
            {
                return this.stack.Length;
            }
        }

        public void Push(T item)
        {
            if (this.Capacity==this.Count)
            {
                Array.Resize(ref this.stack, this.Capacity * 2);
            }

            this.stack[this.Count] = item;
            this.Count++;
        }

        public T Pop()
        {
            T element = this.stack[this.Count-1];
            this.Count--;            

            return element;
        }

        public T Peek()
        {
            return this.stack[this.Count - 1];
        }
    }
}
