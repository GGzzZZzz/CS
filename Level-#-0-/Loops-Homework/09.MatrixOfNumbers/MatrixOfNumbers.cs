using System;
class MatrixOfNumbers
{
    static void Main()
    {
        //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

        Console.Write("Enter number 1 <= n <= 20: ");
        string input = Console.ReadLine();
        int n;
        while (!int.TryParse(input, out n) || (n < 1) || (n > 20)) //Check data is valid
        {
            Console.Write("Invalid input!Enter again!\nn: ");
            input = Console.ReadLine();
        }
        for (int row = 1; row <= n; row++) //Set the row
        {
            Console.Write("{0,5}",row );
            for (int col = row + 1; col < row + n; col++) //Set the column
            {
                Console.Write("{0,5}",col);


            }
            Console.WriteLine("\n");
        }
    }
}