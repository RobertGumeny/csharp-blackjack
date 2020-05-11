using System;

namespace csharp_twentyone
{

  // NOTE Create a Card class.
  public class Card
  {
    public int Value;
    public static string[] SuitsArray = new string[] { "Hearts", "Diamonds", "Clubs", "Spades" };
    public string Suit;
    public Card(int value, string suit)
    {
      Value = value;
      Suit = suit;
    }
  }

  class Deck
  {
    public static Card[] deck = new Card[52];

    public static void FillDeck()
    {
      int index = 0;
      foreach (string suit in Card.SuitsArray)
      {
        for (int value = 2; value <= 14; value++)
        {
          Card card = new Card(value, suit);
          deck[index] = card;
          index++;
        }
      }
    }

    public static void DealCards()
    {
      Random rand = new Random();

      Console.WriteLine("Computer's Hand:");
      for (int n = 0; n < 2; n++)
      {
        int i = rand.Next(1, 53);
        Console.WriteLine($"{deck[i].Value}{deck[i].Suit}");
      }
      Console.WriteLine("Player's Hand:");
      for (int n = 0; n < 2; n++)
      {
        int i = rand.Next(1, 53);
        Console.WriteLine($"{deck[i].Value}{deck[i].Suit}");
      }
    }

    public static void PrintDeck()
    {
      for (int i = 0; i < 52; i++)
      {
        Console.WriteLine($"{deck[i].Value}{deck[i].Suit}");
      }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      // NOTE Greeting and ask user to initialize game.
      Console.WriteLine("Welcome to Twenty One!");
      Deck.FillDeck();
      Console.WriteLine("Would you like to start a new game? Y/N");
      string startGame = Console.ReadLine();
      bool playing = startGame.ToLower() == "y" || startGame.ToLower() == "yes";

      // NOTE Establish deck of 52 cards with 4 suits.
      while (playing)
      {
        Deck.DealCards();
        Console.WriteLine("Would you like to deal again? Y/N");
        string dealAgain = Console.ReadLine();
        if (dealAgain.ToLower() == "y")
        {
          continue;
        }
        else
        {
          playing = false;
        }
      }
      Console.WriteLine("Thanks for playing!");
    }
  }


}
