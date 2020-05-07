using System;
using System.Collections.Generic;

namespace Game.Models
{
  public class Poker
  {
    public static List<string> Deck { get; }

    public static void PupulateDeck()
    {
      string Suit = "";
      string Card = "";
      for (int i = 0; i < 4; i++)
      {
        for (int j = 1; j <= 13; j++)
        {
          //get suit
          switch (i)
          {
            case 0:
              Suit = "Spades";
              break;
            case 1:
              Suit = "Diamonds";
              break;
            case 2:
              Suit = "Clovers";
              break;
            case 3:
              Suit = "Hearts";
              break;
            default:
              Console.WriteLine("Should never see this");
              break;
          }
          //get number
          switch (j)
          {
            case 1:
              Card = "Ace";
              break;
            case 11:
              Card = "Jack";
              break;
            case 12:
              Card = "Queen";
              break;
            case 13:
              Card = "King";
              break;
            default:
              Card = j.ToString();
              break;
          }

          Console.WriteLine($"{Card} of {Suit}");

        }
      }
    }
  }
}