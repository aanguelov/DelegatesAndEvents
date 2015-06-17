using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _01_CustomLINQExtensionMethods
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var matches = new List<T>();
            foreach (var element in collection)
            {
                if (!predicate(element))
                {
                    matches.Add(element);
                }
            }
            return matches;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection,
            Func<TSource, TSelector> selectFunc) where TSelector : IComparable<TSelector>
        {
            var selectors = GetGradesPorperty(collection, selectFunc).ToList();
            TSelector max = selectors[0];
            for (int i = 1; i < selectors.Count; i++)
            {
                TSelector current = selectors[i];
                if (current.CompareTo(max) >= 1)
                {
                    max = current;
                }
            }
            return max;
        }

        public static IEnumerable<K> GetGradesPorperty<T, K>(this IEnumerable<T> collection, Func<T, K> selectFunc)
        {
            var list = new List<K>();
            foreach (var element in collection)
            {
                K grade = selectFunc(element);
                list.Add(grade);
            }
            return list;
        }
    }
}
