namespace _13.LinkedQueue
{
    /*13.Implement the ADT queue as dynamic linked list.
    Use generics (LinkedQueue<T>) to allow storing different data types in the queue.*/

    using System;

    class Program
    {
        static void Main()
        {
            LinkedQueue<int> myQueue = new LinkedQueue<int>();
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
        }
    }
}
