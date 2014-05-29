using System;
class CountOfLetters
{
    static void Main()
    {
        //Write a program that reads a list of letters and prints for each letter how many times it appears in the list. The letters should be listed in alphabetical order.

        string input = Console.ReadLine();
        string[] letters = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(letters);
        int counter = 1;
        for (int i = 1; i < letters.Length; i++)
        {
            int j = i - 1;
            
            if (letters[i] == letters[j])
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", letters[j], counter);
                counter = 1;
            }
            if (i == letters.Length-1)
            {
                Console.WriteLine("{0} -> {1}", letters[i], counter);
            }
        }
    }
}
	
