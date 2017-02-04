using System;
using System.Collections.Generic;

namespace Infrastructure
{
    public static class IEnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action) {
            foreach (T t in enumerable) {
                action(t);
            }
        }
    }
}
