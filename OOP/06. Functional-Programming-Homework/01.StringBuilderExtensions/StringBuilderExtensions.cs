using System;
using System.Collections.Generic;
using System.Text;

public static class StringBuilderExtensions
{
    public static string Substring(this StringBuilder text, int startIndex, int length)
    {
        string result = string.Empty;

        if (startIndex < 0 || startIndex > text.Length - 1)
        {
            throw new IndexOutOfRangeException("Invalid index!");
        }

        for (int i = startIndex; i < startIndex + length; i++)
        {
            result += text[i];
        }

        return result;
    }

    public static StringBuilder RemoveText(this StringBuilder text, string replacedText)
    {
        return text.Replace(replacedText.ToLower(), string.Empty);
    }

    public static StringBuilder AppendAll<T>(this StringBuilder text, IEnumerable<T> items)
    {
        foreach (T item in items)
        {
            text.Append(item);
        }

        return text;
    }
}