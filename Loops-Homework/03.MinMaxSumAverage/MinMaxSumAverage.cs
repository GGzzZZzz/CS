using System;
class MinMaxSumAverage
{
    static void Main()
    {
        //Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        int maxNum = Int32.MinValue;
        int minNum = Int32.MaxValue;
        int sum = 0;
        double averageNum = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            maxNum = Math.Max(maxNum, num);
            minNum = Math.Min(minNum, num);
            sum += num;
        }
        averageNum = (double)sum / (double)n;
        Console.WriteLine("min = {0}",minNum);
        Console.WriteLine("max = {0}",maxNum);
        Console.WriteLine("sum = {0}",sum);
        Console.WriteLine("avg = {0:F2}",averageNum);
    }
}