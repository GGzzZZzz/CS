using System;
using System.Numerics;

public enum Players
{
    First,
    Second
}
class CardWars
{
    const int numberCardsPerHand = 3;
    static BigInteger firstPlayerScore = 0;
    static BigInteger secondPlayerScore = 0;
    static bool firstPlayerXCardDrawn = false;
    static bool secondPlayerXCardDrawn = false;
    static int firstPlayerGameWon = 0;
    static int secondPlayerGameWon = 0;
    
    static void Main()
    {
        int numberOfGames = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfGames; i++)
        {
            int currentFirstPlayerScore = 0;
            int currentSecondPlayerScore = 0;
            for (int j = 0; j < numberCardsPerHand ; j++)
            {
                currentFirstPlayerScore += CalculatePoints(Players.First);
            }
            for (int j = 0; j < numberCardsPerHand; j++)
            {
                currentSecondPlayerScore += CalculatePoints(Players.Second);
            }
            if (firstPlayerXCardDrawn && secondPlayerXCardDrawn)
            {
                firstPlayerScore += 50;
                secondPlayerScore += 50;
                firstPlayerXCardDrawn = false;
                secondPlayerXCardDrawn = false;
            }
            else if (firstPlayerXCardDrawn)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                return;
            }
            else if (secondPlayerXCardDrawn)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                return;
            }
            if (currentFirstPlayerScore > currentSecondPlayerScore)
            {
                firstPlayerScore += currentFirstPlayerScore;
                firstPlayerGameWon++;
            }
            else if(currentSecondPlayerScore > currentFirstPlayerScore)
            {
                secondPlayerScore += currentSecondPlayerScore;
                secondPlayerGameWon++;
            }
        }
        if (firstPlayerScore > secondPlayerScore)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}",firstPlayerScore);
            Console.WriteLine("Games won: {0}",firstPlayerGameWon);
        }
        else if (secondPlayerScore > firstPlayerScore)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}",secondPlayerScore);
            Console.WriteLine("Games won: {0}",secondPlayerGameWon);
        }
        else
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}",firstPlayerScore);
        }
    }

    private static int CalculatePoints(Players player)
    {
        int points = 0;
        string card = Console.ReadLine();
        switch (card)
        {
            case "A": points += 1; break;
            case "J": points += 11; break;
            case "Q": points += 12; break;
            case "K": points += 13; break;
            case "Y":
                {
                    if (player==Players.First)
                    {
                        firstPlayerScore -= 200;
                    }
                    else
                    {
                        secondPlayerScore -= 200;
                    }
                }
                break;
            case "Z":
                {
                    if (player==Players.First)
                    {
                        firstPlayerScore *= 2;
                    }
                    else
                    {
                        secondPlayerScore *= 2;
                    }
                }
                break;
            case "X":
                {
                    if (player == Players.First)
                    {
                        firstPlayerXCardDrawn = true;
                    }
                    else
                    {
                        secondPlayerXCardDrawn = true;
                    }
                }
                break;

            default: points += 12 - int.Parse(card);
                break;
        }
        return points;
    }
}