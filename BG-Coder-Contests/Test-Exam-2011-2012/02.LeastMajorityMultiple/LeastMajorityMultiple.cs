using System;
class LeastMajorityMultiple
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int i;
        if (a > 0 && b > 0 && c > 0 && d > 0 && e > 0)
        {
            for (i = 1; i < Int32.MaxValue; i++)
            {
                if ((i % a == 0) && (i % b == 0) && (i % c == 0))
                {
                    break;
                }
                else if ((i % b == 0) && (i % c == 0) && (i % d == 0))
                {
                    break;
                }
                else if ((i % c == 0) && (i % d == 0) && (i % e == 0))
                {
                    break;
                }
                else if ((i % d == 0) && (i % e == 0) && (i % a == 0))
                {
                    break;
                }
                else if ((i % e == 0) && (i % a == 0) && (i % b == 0))
                {
                    break;
                }
                else if ((i % b == 0) && (i % d == 0) && (i % a == 0))
                {
                    break;
                }
                else if ((i % a == 0) && (i % c == 0) && (i % e == 0))
                {
                    break;
                }
                else if ((i % b == 0) && (i % c == 0) && (i % e == 0))
                {
                    break;
                }
                else if ((i % d == 0) && (i % a == 0) && (i % c == 0))
                {
                    break;
                }
                else if ((i % e == 0) && (i % b == 0) && (i % d == 0))
                {
                    break;
                }
            }
            Console.WriteLine(i);
        }
    }
}