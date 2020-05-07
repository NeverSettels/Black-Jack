using System;
using System.Collections.Generic;
using Game.Models;

namespace Game
{
  public class Program
  {
    public static void HoldHit()
    {
      Console.WriteLine($"Your hand Gives you: {Poker.PlayerScore} Points would you like to hit? or hold");
      string hitOrHold = Console.ReadLine().ToLower();
      if (hitOrHold == "hold")
      {
        Console.WriteLine($"Winner: {Poker.CompareScore(Poker.PlayerScore, Poker.DealerScore)}");
        Main();
      }
      else
      {
        Poker.PlayerHand.Add(Poker.Hit());
        Poker.DevShowDeck(Poker.PlayerHand);
        Poker.PlayerScore = Poker.ClacScore(Poker.PlayerHand);
        string state = Poker.CheckState(Poker.PlayerScore);
        if (state == "Black Jack")
        {
          Console.WriteLine($"{state}! You win!");
          Main();
        }
        else if (state == "Bust")
        {
          Console.WriteLine($"Your hand Gives you: {Poker.PlayerScore}! You Busted!");
          Main();
        }
        else
        {
          Console.WriteLine($"Your hand Gives you: {Poker.PlayerScore} Points would you like to hit? or hold");
          HoldHit();
        }
      }
    }
    public static void Main()
    {


      // Poker.PupulateDeck();
      // Poker game = new Poker();
      // Poker.PlayerHand = Poker.DealInitialHand();
      // Poker.DealerHand = Poker.DealInitialHand();
      // //Poker.Hit();
      // Poker.DevShowDeck(Poker.PlayerHand);
      // //Poker.DevShowDeck(Poker.DealerHand);
      // Poker.ClacScore(Poker.PlayerHand);
      // Console.WriteLine();
      // //Poker.DevShowDeck(Poker.Deck);
      Console.Write("Would you like to play a hand of Black Jack? y/n :");
      string yOrN = Console.ReadLine().ToLower();
      if (yOrN == "n")
      {
        Console.WriteLine("Okay Bye!");
      }
      else
      {
        Poker.PupulateDeck();
        Poker.PlayerHand = Poker.DealInitialHand();
        Poker.DealerHand = Poker.DealInitialHand();
        Poker.PlayerScore = Poker.ClacScore(Poker.PlayerHand);
        Poker.DealerScore = Poker.ClacScore(Poker.DealerHand);
        Poker.DevShowDeck(Poker.PlayerHand);
        HoldHit();


      }
    }
  }
}