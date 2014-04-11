using System;
class ExcelColumns
{
    static void Main()
    {
        int indexLenght = int.Parse(Console.ReadLine());
        char[] letters = new char[indexLenght];
        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = char.Parse(Console.ReadLine());
        }
        long indexNumber = 0;
        Array.Reverse(letters);
        for (int i = 0; i < letters.Length; i++)
        {
            indexNumber += (letters[i] - 64) * (long)Math.Pow(26, i);
        }
        Console.WriteLine(indexNumber);
    }
}