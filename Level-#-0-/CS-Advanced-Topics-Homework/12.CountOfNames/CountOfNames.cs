using System;
class CountOfNames
{
    static void Main()
    {
        //Write a program that reads a list of names and prints for each name how many times it appears in the list. The names should be listed in alphabetical order.

        string input = Console.ReadLine();
        string[]names = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(names);
        int counter = 1;
        for (int i = 1; i < names.Length; i++)
        {
            int j = i - 1;

            if (names[i] == names[j])
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", names[j], counter);
                counter = 1;
            }
            if (i == names.Length - 1)
            {
                Console.WriteLine("{0} -> {1}", names[i], counter);
            }
        }
    }
}