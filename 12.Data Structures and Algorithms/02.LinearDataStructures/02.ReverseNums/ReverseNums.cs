namespace _02.ReverseNums
{
    /*2.Write a program that reads N integers from the console and reverses them using a stack.
Use the Stack<int> class.*/

    using System;
    using System.Collections.Generic;

    public class ReverseNums
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive integer number:");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} integer numbers:", count);
            int number = 0;
            Stack<int> nums = new Stack<int>();

            for (int i = 0; i < count; i++)
            {
                number = int.Parse(Console.ReadLine());
                nums.Push(number);
            }

            while (nums.Count > 0)
            {
                number = nums.Pop();
                Console.WriteLine(number);
            }
        }
    }
}
