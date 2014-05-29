using System;
class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}",new string('-',n/2));
        
        int outerDash = n / 2 - 1;
        int innerDash = 1;
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string('-',outerDash),new string('-',innerDash));
            outerDash--;
            innerDash += 2;
        }
        outerDash = innerDash-4;
        innerDash = 1;

        for (int i = 0; i < n/2-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string('-',innerDash),new string('-',outerDash));
            innerDash++;
            outerDash -= 2;
        }
        Console.WriteLine("{0}*{0}", new string('-', n / 2));
    }
}