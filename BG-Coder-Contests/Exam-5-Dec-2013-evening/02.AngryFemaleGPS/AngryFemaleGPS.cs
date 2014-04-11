using System;
class AngryFemaleGPS
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        string number = Convert.ToString(n);
        number = number.TrimStart('-');
        int evenSum = 0;
        int oddSum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if(int.Parse(number[i].ToString()) % 2 == 0)
            {
                evenSum += int.Parse(number[i].ToString());
            }
            else
            {
                oddSum += int.Parse(number[i].ToString());
            }
        }
        if(evenSum > oddSum)
        {
            Console.Write("right "+ evenSum);
        }
        if(oddSum > evenSum)
        {
            Console.Write("left "+ oddSum);
        }
        if(evenSum == oddSum)
        {
            Console.Write("straight " + Math.Max(evenSum,oddSum));
        }
    }
}