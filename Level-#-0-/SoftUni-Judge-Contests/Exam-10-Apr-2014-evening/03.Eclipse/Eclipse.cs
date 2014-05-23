using System;
class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{2}{1}{0}",new string(' ',1),new string('*',n * 2 - 2),new string(' ',n + 1),new string('*',n * 2-2),new string(' ',n + 1));
        for (int i = 1; i <= n-2; i++)
        {
            if (i == n/2)
            {
                Console.WriteLine("*{0}*{1}*{0}*",new string('/',n * 2 - 2),new string('-',n - 1));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string(' ', n - 1));
            }
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string(' ', 1), new string('*', n * 2 - 2), new string(' ', n + 1), new string('*', n * 2 - 2), new string(' ', n + 1));
    }
}