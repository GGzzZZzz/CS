using System;
class OddAndEvenProduct
{
    static void Main()
    {
        //You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

        string input = Console.ReadLine();
        string[] splitNums = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int oddProduct = 1;
        int evenProduct = 1;
        int num;
        for (int i = 0; i < splitNums.Length; i += 2)
        {
            num = int.Parse(splitNums[i]);
            oddProduct *= num;
        }
        for (int j = 1; j < splitNums.Length; j += 2)
        {
            num = int.Parse(splitNums[j]);
            evenProduct *= num;
        }
        if (oddProduct == evenProduct )
        {
            Console.WriteLine("Yes \nproduct = {0}",oddProduct=evenProduct);
        }
        else
        {
            Console.WriteLine("No \nodd product = {0}\neven product = {1}",oddProduct,evenProduct);
        }
    }
}