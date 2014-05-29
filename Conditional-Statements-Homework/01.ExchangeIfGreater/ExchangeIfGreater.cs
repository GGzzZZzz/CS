using System;
class ExchangeIfGreater
{
    static void Main()
    {
        //Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space. 

        Console.WriteLine("Enter 2 integers each on a single line");
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        if(first > second)
        {
            first ^= second; //XOR swap algorithm
            second ^= first;
            first ^= second;
        }
        Console.Write("{0} {1}\n",first,second);
    }
}