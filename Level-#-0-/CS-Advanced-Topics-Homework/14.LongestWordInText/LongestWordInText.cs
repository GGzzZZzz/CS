using System;
using System.Linq;
class LongestWordInText
{
    static void Main()
    {
        //Write a program to find the longest word in a text.

        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ','.',',',';',':','-','?','!'}, StringSplitOptions.RemoveEmptyEntries);
        string longest = words.OrderByDescending( s => s.Length ).First();
        Console.WriteLine(longest);
    }
}