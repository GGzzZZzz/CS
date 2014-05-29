using System;
class SumOfElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[]splited = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] elements = new int[splited.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            elements[i] = Convert.ToInt32(splited[i]);
        }
        Array.Sort(elements);
        long sum = 0;
        for (int i = 0; i < elements.Length-1; i++)
        {
            sum += elements[i];
        }
        if (sum == elements[elements.Length-1])
        {
            Console.WriteLine("Yes, sum={0}",sum);
        }
        else
        {
            Console.WriteLine("No, diff={0}",Math.Abs(elements[elements.Length-1] - sum));
        }
    }
} 