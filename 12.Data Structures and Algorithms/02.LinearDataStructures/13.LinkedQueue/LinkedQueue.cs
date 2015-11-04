namespace _13.LinkedQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LinkedQueue<T>
    {
        private LinkedList<T> list;

        public LinkedQueue()
        {
            this.list = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            this.list.AddLast(item);
        }

        public T Dequeue()
        {
            if (this.list.Count==0)
            {
                throw new ArgumentNullException("There are no items in the queue");
            }

            T item = this.list.First();
            this.list.RemoveFirst();

            return item;
        }
    }
}
