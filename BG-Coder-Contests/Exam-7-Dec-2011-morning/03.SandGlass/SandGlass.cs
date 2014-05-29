using System;
class SandGlass
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        Console.Write(new string('*', n));
        Console.WriteLine();
        for (int i = 1; i < n / 2 + 1; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('*', n - 2 * i));
            Console.Write(new string('.', i));
            Console.WriteLine();
        }
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('*', n - 2 * i));
            Console.Write(new string('.', i));
            Console.WriteLine();
        }
    }
}