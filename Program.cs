using System;
using System.Collections.Generic;
using Game.Models;

namespace Game
{
  public class Program
  {
    public static void Main()
    {
      Poker game = new Poker();
      Poker.PupulateDeck();
      Poker.Hit();
      Poker.DevShowDeck();
    }
  }
}