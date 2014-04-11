using System;
class CoffeeMachine
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());
        float a = float.Parse(Console.ReadLine());
        float p = float.Parse(Console.ReadLine());
        float sumN1 = n1 * 0.05f;
        float sumN2 = n2 * 0.10f;
        float sumN3 = n3 * 0.20f;
        float sumN4 = n4 * 0.50f;
        float sumN5 = n5 * 1.00f;
        float sum = sumN1 + sumN2 + sumN3 + sumN4 + sumN5;
        float change = 0;
        float result = 0;
        if (a >= p)
        {
            change = a - p;
            if (sum >= change)
            {
                result = sum - change;
                Console.WriteLine("Yes {0:F2}", result);
            }
        }
        if (a < p)
        {
            change = p - a;
            Console.WriteLine("More {0:F2}",change);
        }
        if (a > p)
        {
            change = a - p;
            if (sum < change)
            {
                result = change - sum;
                Console.WriteLine("No {0:F2}", result);
            }
        }
    }
}