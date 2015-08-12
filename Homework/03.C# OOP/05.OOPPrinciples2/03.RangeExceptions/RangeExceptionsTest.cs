//Problem 3. Range Exceptions
//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].


namespace _03.RangeExceptions
{
    using System;

    class RangeExceptionsTest
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 100)
            {
                throw new InvalidRangeException<int>(0, 100);
            }

            Console.WriteLine("Enter date dd.mm.yyyy");
            DateTime date = DateTime.Parse(Console.ReadLine());
            DateTime start = new DateTime(1980, 01, 01);
            DateTime end = new DateTime(2013, 12, 31);

            if (date < start || date > end)
            {
                throw new InvalidRangeException<DateTime>(start, end);
            }
        }
    }
}

