using System;
using System.Collections.Generic;
using System.Linq;

public static class CustomLINQExtensionMethods
{
    public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        return collection.Where(item => !predicate(item));
    }

    public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
    {
        IEnumerable<T> result = collection;
        for (int i = 0; i < count - 1; i++)
        {
            result = collection.Concat(result);
        }

        return result;
    }

    public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
    {
        var result = new List<string>();

        foreach (var item in collection)
        {
            foreach (var suffix in suffixes)
            {
                if (item.EndsWith(suffix))
                {
                    result.Add(item);
                }
            }
        }

        return result as IEnumerable<string>;
    }
}