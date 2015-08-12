
namespace Students
{
    using System;
    using System.Collections.Generic;

    public static class IEnumerableExtentions
    {
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }
    }
}
