using System;

internal class AsyncTimerTest
{
    public static void PrintText()
    {
        Console.WriteLine("Object Oriented Programming is amazing!");
    }

    public static void PrintNumbers()
    {
        Random rand = new Random();
        Console.WriteLine(rand.Next(0, 1000));
    }

    public static void Main()
    {
        AsyncTimer timerOne = new AsyncTimer(PrintText, 7, 2000);
        timerOne.Start();

        AsyncTimer timerTwo = new AsyncTimer(PrintNumbers, 10, 1000);
        timerTwo.Start();
    }
}