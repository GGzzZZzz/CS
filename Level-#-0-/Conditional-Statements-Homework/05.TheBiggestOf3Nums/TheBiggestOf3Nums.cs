using System;
class TheBiggestOf3Nums
{
    static void Main()
    {
        //Write a program that finds the biggest of three numbers.

        Console.WriteLine("Enter 3 numbers each on a single line");
        double one = double.Parse(Console.ReadLine());
        double two = double.Parse(Console.ReadLine());
        double three = double.Parse(Console.ReadLine());
        if (one >= two && one >= three)
        {
            Console.WriteLine(one);
        }
        else if(two >= one && two >= three)
        {
            Console.WriteLine(two);
        }
        else
        {
            Console.WriteLine(three);
        }
    }
}