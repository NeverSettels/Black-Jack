using System;
using System.Collections.Generic;
using Game.Models;

namespace Game
{
  public class Program
  {
    public static void Main()
    {
      Poker.PupulateDeck();
      Poker game = new Poker();
      Poker.PlayerHand = Poker.DealInitialHand();
      Poker.DealerHand = Poker.DealInitialHand();
      //Poker.Hit();
      Poker.DevShowDeck(Poker.PlayerHand);
      Poker.DevShowDeck(Poker.DealerHand);
      Console.WriteLine();
      Poker.DevShowDeck(Poker.Deck);
    }
  }
}