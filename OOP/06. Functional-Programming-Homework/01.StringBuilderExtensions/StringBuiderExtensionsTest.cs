using System;
using System.Text;

public class StringBuiderExtensionsTest
{
    public static void Main()
    {
        StringBuilder text = new StringBuilder("C# is a very powerful programming language.");

        Console.WriteLine(text.Substring(0, 5));

        Console.WriteLine(text.RemoveText("very"));

        int[] nums = new int[] { 0, 1, 2, 3, 4, 5 };
        Console.WriteLine(text.AppendAll(nums));
    }
}