using System;
class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write(new string('.', n));
        Console.Write(new string('*', n));
        Console.WriteLine();
        for (int i = 1; i < n; i++)
        {
            Console.Write(new string('.', n - i));
            Console.Write('*');
            Console.Write(new string('.', i + n - 2));
            Console.Write('*');
            Console.WriteLine();
        }
        Console.Write(new string('*', 2 * n));
    }
}