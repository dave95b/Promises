using System;
using System.Collections.Generic;

namespace Promises
{
    /// <summary>
    /// General extensions to LINQ.
    /// </summary>
    public static class EnumerableExt
    {
        public static void Each<T>(this IEnumerable<T> source, Action<T> fn)
        {
            foreach (var item in source)
                fn.Invoke(item);
        }

        public static void Each<T>(this IEnumerable<T> source, Action<T, int> fn)
        {
            int index = 0;

            foreach (T item in source)
            {
                fn.Invoke(item, index);
                index++;
            }
        }
    }
}
