//Problem 2. IEnumerable extensions
//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.


namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    //using System.Linq;

    class IEnumerableExtensions
    {
        static void Main()
        {
            IEnumerable<int> x = new List<int>() { 1, 9, 45, -6 };
            Console.WriteLine(x.Sum());
            Console.WriteLine(x.Product());
            Console.WriteLine(x.Min());
            Console.WriteLine(x.Max());
            Console.WriteLine(x.Average());
        }
    }
}

