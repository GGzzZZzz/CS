using System;
using System.Collections.Generic;
using System.Linq;
class RemoveNames
{
    static void Main()
    {
        //Write a program that takes as input two lists of names and removes from the first list all names given in the second list. The input and output lists are given as words, separated by a space, each list at a separate line.

        string inputLineOne = Console.ReadLine();
        string[] splittedOne = inputLineOne.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string inputLineTwo = Console.ReadLine();
        string[] splittedTwo = inputLineTwo.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> names = splittedOne.ToList();
        List<string> removeNames = splittedTwo.ToList();
        for (int i = 0; i < removeNames.Count; i++)
        {
            for (int j = 0; j < names.Count; j++)
            {
                if (names.Contains(removeNames[i]))
                {
                    names.Remove(removeNames[i]);
                }
            }
        }
        foreach (string name in names)
        {
            Console.Write("{0} ", name);
        }
        Console.WriteLine();
    }
}