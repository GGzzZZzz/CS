using System;
using System.Collections.Generic;
using System.Linq;
class JoinLists
{
    static void Main()
    {
        //Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, separated by a space, each list at a separate line.

        string inputOne = Console.ReadLine();
        string[] splittedOne = inputOne.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string inputTwo = Console.ReadLine();
        string[] splittedTwo = inputTwo.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> firstList = splittedOne.ToList();
        List<string> secondList = splittedTwo.ToList();
        //Clear the same numbers
        for (int i = 0; i < secondList.Count; i++)
        {
            for (int j = 0; j < firstList.Count; j++)
            {
                if (firstList.Contains(secondList[i]))
                {
                    firstList.Remove(secondList[i]);
                }
            }
        }
        //Add the rest of list to the other
        for (int i = 0; i < secondList.Count; i++)
        {
            firstList.Add(secondList[i]);
        }
        firstList.Sort();
        foreach (string number in firstList)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}