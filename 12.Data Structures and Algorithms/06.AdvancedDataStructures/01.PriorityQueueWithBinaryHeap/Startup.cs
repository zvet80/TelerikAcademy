namespace _01.PriorityQueueWithBinaryHeap
{
    //1.Implement a class PriorityQueue<T> based on the data structure "binary heap".

    using System;

    public class Startup
    {
        public static void Main()
        {
            var queue = new PriorityQueue<int>();
            queue.Enqueue(6);
            queue.Enqueue(5);
            queue.Enqueue(3);
            Console.WriteLine(queue.Peek());
            queue.Enqueue(1);
            queue.Enqueue(8);
            queue.Enqueue(7);
            queue.Enqueue(2);
            queue.Enqueue(4);
            Console.WriteLine(queue.Peek());

            while (queue.Size > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
