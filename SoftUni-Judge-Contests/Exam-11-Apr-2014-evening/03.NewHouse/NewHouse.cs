using System;
class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDash = n / 2;
        int innerAsterix = 1;
        for (int i = 0; i < n/2 + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string('-',outerDash),new string('*',innerAsterix));
            outerDash--;
            innerAsterix += 2;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string('|',1),new string('*',n-2));
        }
    }
}