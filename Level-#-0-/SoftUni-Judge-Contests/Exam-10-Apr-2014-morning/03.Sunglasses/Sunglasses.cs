using System;
class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = n;
        int width = (n * 4) + n; 
        Console.WriteLine("{0}{1}{0}",new string('*',n * 2),new string(' ',n),new string('*',n * 2));
        for (int i = 0; i < height - 2; i++)
        {
            if(i == (height / 2) -1)
            {
                Console.WriteLine("*{0}*{1}*{0}*",new string('/',n * 2 -2),new string('|',n),new string('/', n * 2 - 2));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string(' ', n), new string('/', n * 2 - 2));
            }
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n), new string('*', n * 2));
    }
}