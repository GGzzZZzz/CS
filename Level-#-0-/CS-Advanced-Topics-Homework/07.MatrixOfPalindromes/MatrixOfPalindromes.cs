using System;
class MatrixOfPalindromes
{
    static void Main()
    {
        //Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns.

        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("" + (char)('a' + i) + (char)('a' + i + j) + (char)('a' + i) + " ");
            }
            Console.WriteLine();
        }
    }
}