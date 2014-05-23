using System;
class DiamondTrolls
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = n * 2 + 1;
        int height = (6 + ((n - 3) / 2) * 3);
        Console.WriteLine("{0}{1}{0}",new string('.',n/2 +1),new string('*',n));
        for (int i = 0; i < n /2; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', (n / 2) - i), new string('.', (n / 2) + i));
        }
        Console.WriteLine("{0}",new string('*',width));
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}",new string('.',i + 1),new string('.',n-2 - i));
        }
        Console.WriteLine("{0}*{0}",new string('.',n));
    }
}