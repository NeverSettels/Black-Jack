using System;
using System.Collections.Generic;
using Game.Models;

namespace Prime
{
  public class Program
  {
    public static void Main()
    {
      //Poker game = new Poker();
      Poker.PupulateDeck();
      Poker.Hit();
    }
  }
}