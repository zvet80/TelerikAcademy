
namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public static class IEnumerableExtension
    {
        public static T Sum<T>(this IEnumerable<T> input)
        {
            T result = (dynamic)0;

            foreach (var item in input)
            {
                result += (dynamic)item;
            }
            return result;
        }

        public static T Product<T>(this IEnumerable<T> input)
        {
            T result = (dynamic)1;

            foreach (var item in input)
            {
                result *= (dynamic)item;
            }
            return result;
        }

        public static T Max<T>(this IEnumerable<T> input) where T : IComparable
        {
            T max = input.ElementAt(0);

            foreach (var item in input)
            {
                if (item.CompareTo(max)>0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static T Min<T>(this IEnumerable<T> input) where T : IComparable
        {
            T min = input.ElementAt(0);
            
            foreach (var item in input)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Average<T>(this IEnumerable<T> input)
        {
            return (dynamic)input.Sum() / input.Count();
        }
    }
}
