using System;
class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = n * 2 - 3;
        Console.Write(new string('.', width / 2));
        Console.Write('*');
        Console.Write(new string('.', width / 2));
        Console.WriteLine();
        for (int i = 1; i < n / 2; i++)
        {
            Console.Write(new string('.', width / 2 - i));
            Console.Write(new string('*', i + i + 1));
            Console.Write(new string('.', width / 2 - i));
            Console.WriteLine();
        }
        for (int i = n / 2; i < n - 1; i++)
        {
            Console.Write(new string('.', width / 2 - i));
            Console.Write(new string('*', i + i + 1));
            Console.Write(new string('.', width / 2 - i));
            Console.WriteLine();
        }
        Console.Write(new string('.', width / 2));
        Console.Write('*');
        Console.Write(new string('.', width / 2));
        Console.WriteLine();
    }
}