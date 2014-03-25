using System;
class TheBiggestOf5Nums
{
    static void Main()
    {
        //Write a program that finds the biggest of five numbers by using only five if statements. 

        Console.WriteLine("Enter 5 numbers each on a single line");
        double one = double.Parse(Console.ReadLine());
        double two = double.Parse(Console.ReadLine());
        double three = double.Parse(Console.ReadLine());
        double four = double.Parse(Console.ReadLine());
        double five = double.Parse(Console.ReadLine());
        if (one >= two && one >= three && one >= four && one >= five)
        {
            Console.WriteLine(one);
        }
        else if(two >= one && two >= three && two >= four && two >= five)
        {
            Console.WriteLine(two);
        }
        else if(three >= one && three >= two && three >= four && three >= five)
        {
            Console.WriteLine(three);
        }
        else if(four >= one && four >= two && four >= three && four >= five)
        {
            Console.WriteLine(four);
        }
        else
        {
            Console.WriteLine(five);
        }
    }
}