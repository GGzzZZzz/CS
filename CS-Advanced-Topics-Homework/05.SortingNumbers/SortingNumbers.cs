using System;
class SortingNumbers
{
    static void Main()
    {
        //Write a program that reads a number n and a sequence of n integers, sorts them and prints them.

        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}