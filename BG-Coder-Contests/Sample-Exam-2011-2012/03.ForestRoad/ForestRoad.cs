using System;
class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = (2 * n) - 1;
        Console.Write('*');
        Console.Write(new string('.', n - 1));
        Console.WriteLine();

        for (int i = height - 1; i > height / 2; i--)
        {
            Console.Write(new string('.', height - i));
            Console.Write('*');
            Console.Write(new string('.', i - n));
            Console.WriteLine();
        }
        for (int j = height - 1; j > height / 2; j--)
        {
            Console.Write(new string('.', j - n));
            Console.Write('*');
            Console.Write(new string('.', height - j));
            Console.WriteLine();
        }
    }
}