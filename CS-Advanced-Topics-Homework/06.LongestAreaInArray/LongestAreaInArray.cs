using System;
class LongestAreaInArray
{
    static void Main()
    {
        //Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them.

        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Console.ReadLine();
        }
        int start = 0;
        int bestLenght = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int counter = 0;
            int j = i;
            while (arr[i] == arr[j])
            {
                counter++;
                j++;
                if (j >= arr.Length)
                {
                    break;
                }
            }
            if (counter > bestLenght)
            {
                bestLenght = counter;
                start = i;
            }
        }
        Console.WriteLine(bestLenght);
        for (int i = start; i <= start + bestLenght - 1; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}