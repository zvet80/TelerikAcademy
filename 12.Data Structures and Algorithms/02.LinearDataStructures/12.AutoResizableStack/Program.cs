namespace _12.AutoResizableStack
{
    /*12.Implement the ADT stack as auto-resizable array.
    Resize the capacity on demand (when no space is available to add / insert a new element).*/

    using System;

    class Program
    {
        static void Main()
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(3);
            myStack.Push(5);
            myStack.Push(9);
            myStack.Push(8);
            Console.WriteLine(myStack.Capacity);
            myStack.Push(16);
            myStack.Push(17);
            Console.WriteLine(myStack.Count);
            Console.WriteLine(myStack.Capacity);            
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Count);
            Console.WriteLine(myStack.Capacity);
        }
    }
}
