using System;
class PlayWithDataTypes
{
    static void Main()
    {
        //Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement.

        Console.Write("Choose data type (1 for int, 2 for double and 3 for string: ");
        byte choise = byte.Parse(Console.ReadLine());
        switch (choise)
        {
            case 1: Console.Write("Enter an int: ");
                int intNum = int.Parse(Console.ReadLine());
                Console.WriteLine(intNum + 1);break;
            case 2: Console.Write("Enter a double: ");
                double doubleNum = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNum + 1);break;
            case 3: Console.Write("Enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str + "*");break;
            default: Console.WriteLine("Incorrect input!"); break;
                
        }
    }
}
