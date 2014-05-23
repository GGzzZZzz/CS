using System;
class PrimeChecker
{
    static void Main()
    {
        //Write a Boolean method IsPrime(n) that check whether a given integer number n is prime.

        long n = long.Parse(Console.ReadLine());
        IsPrime(n);
    }
    static void IsPrime(long n)
    {
        if (n < 2)
        {
            Console.WriteLine(false);
        }
        else
        {
            bool isPrime = true;
            int counter = 1;
            while (counter <= Math.Sqrt(n))
            {
                if (n % counter == 0 && counter > 1)
                {
                    isPrime = false;
                }
                counter++;
            }
            Console.WriteLine(isPrime);
        }
    }
}