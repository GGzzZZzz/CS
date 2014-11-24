using System;
using System.Collections.Generic;
using System.Linq;

public class CustomLINQEntensionsTest
{
    public static void Main()
    {
        List<int> numbers = new List<int> { 2, 3, 5, 10, 28, 37, 44 };
        var result = numbers.WhereNot<int>(item => item % 2 == 0);
        Console.WriteLine(string.Join(", ", result));

        Console.WriteLine(string.Join(", ", numbers.Repeat<int>(3)));

        List<string> words = new List<string> { "Programming", "is", "very", "exciting" };
        List<string> suffixes = new List<string> { "ing", "ry" };

        Console.WriteLine(string.Join(", ", words.WhereEndsWith(suffixes)));
    }
}