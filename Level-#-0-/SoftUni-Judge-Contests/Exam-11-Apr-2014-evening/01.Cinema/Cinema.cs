using System;
class Cinema
{
    static void Main()
    {
        string type = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        int numberOfPeople = rows * columns;
        double profit = 0;
        if (type == "Premiere")
        {
            profit = numberOfPeople * 12.00;
        }
        else if (type == "Normal")
        {
            profit = numberOfPeople * 7.50;
        }
        else if (type == "Discount")
        {
            profit = numberOfPeople * 5.00;
        }
        Console.WriteLine("{0:F2} leva",profit);
    }
}