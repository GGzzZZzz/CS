using System;
class PrintDeckOf52Cards2
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] symbols = { "\u2665", "\u2666", "\u2660", "\u2663" };
        foreach (var card in cards)
        {
            foreach (var symbol in symbols)
            {
                Console.Write(card + symbol + " ");
            }
            Console.WriteLine();
        }
    }
}