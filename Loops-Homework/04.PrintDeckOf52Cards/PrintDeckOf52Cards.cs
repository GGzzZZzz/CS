using System;
class PrintDeckOf52Cards
{
    static void Main()
    {
        //Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
        
        string[] cards = { "2","3","4","5","6","7","8","9","10","J","Q","K","A" };
        string[] symbols = { "\u2665","\u2666","\u2660","\u2663"};
        for (int i = 0; i < 13; i++)
        {
           for(int j = 0; j < 4; j++)
           {
               switch(cards[i])
               {
                   case "2": Console.Write(cards[i] + symbols[j] + " "); break;
                   case "3": Console.Write(cards[i] + symbols[j] + " "); break;
                   case "4": Console.Write(cards[i] + symbols[j] + " "); break;
                   case "5": Console.Write(cards[i] + symbols[j] + " "); break;
                   case "6": Console.Write(cards[i] + symbols[j] + " "); break;
                   case "7": Console.Write(cards[i] + symbols[j] + " "); break;
                   case "8": Console.Write(cards[i] + symbols[j] + " "); break;
                   case "9": Console.Write(cards[i] + symbols[j] + " "); break;
                   case "10": Console.Write(cards[i] + symbols[j] + " "); break;
                   case "J": Console.Write(cards[i] + symbols[j] + " "); break;
                   case "Q": Console.Write(cards[i] + symbols[j] + " "); break;
                   case "K": Console.Write(cards[i] + symbols[j] + " "); break;
                   case "A": Console.Write(cards[i] + symbols[j] + " "); break;
               }
           }
           Console.WriteLine();
        }
    }
}