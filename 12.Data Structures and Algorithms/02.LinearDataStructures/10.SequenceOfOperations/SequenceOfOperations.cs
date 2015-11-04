namespace _10.SequenceOfOperations
{
    /*10.We are given numbers N and M and the following operations:
        N = N+1
        N = N+2
        N = N*2
        Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.

        Hint: use a queue.
        Example: N = 5, M = 16
        Sequence: 5 → 7 → 8 → 16*/

    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SequenceOfOperations
    {
        static void Main()
        {
            Console.WriteLine("Enter start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number: ");
            int end = int.Parse(Console.ReadLine());
            FindShortestSequenceOfOperations(start, end);
        }

        public static void FindShortestSequenceOfOperations(int start, int end)
        {
            Queue<int> steps = new Queue<int>();
            int current = end;

            while (current >= start)
            {
                steps.Enqueue(current);

                if (current / 2 >= start)
                {
                    if (current % 2 == 0)
                    {
                        current /= 2;
                    }
                    else
                    {
                        current -= 1;
                    }
                }
                else if (current - 2 >= start)
                {
                    current -= 2;
                }
                else
                {
                    current -= 1;
                }
            }
            Console.WriteLine(string.Join(" -> ", steps.Reverse()));
        }
    }
}