using System;
class HalfSum
{
    static void Main()
    {
        int countOfNums = int.Parse(Console.ReadLine());
        int[] numbers = new int[countOfNums * 2];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int leftSum = 0;
        int rightSum = 0;
        int difference = 0;
        for (int i = 0; i < numbers.Length/2; i++)
        {
            leftSum += numbers[i];
        }
        for (int i = numbers.Length/2; i < numbers.Length; i++)
        {
            rightSum += numbers[i];
        }
        if (leftSum == rightSum)
        {
            Console.WriteLine("Yes, sum={0}",leftSum);
        }
        else
        {
            difference = Math.Abs(leftSum - rightSum);
            Console.WriteLine("No, diff={0}",difference);
        }
    }
}