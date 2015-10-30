using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace blackjack_game
{
  public class CardDeckController
  {
    CardDeckView _cardDeckView;
    public CardDeckModel _cardDeckModel;
    public int teller = 0;
    public string[] shuffledDeck;


    public CardDeckController()
    {
      _cardDeckView = new CardDeckView(this);
      _cardDeckModel = new CardDeckModel();
    }

    public CardDeckView getView()
    {
      return _cardDeckView;
    }

    public string[] shuffle()
    {
      Random rnd = new Random();
      _cardDeckModel.ArrCards = _cardDeckModel.ArrCards.OrderBy(x => rnd.Next()).ToArray();
      return shuffledDeck;
    }

    public string getRandomCard()
    {
      string drawCard = _cardDeckModel.ArrCards[teller];
      Console.WriteLine(drawCard);
      teller++;
      return drawCard;
    }

    public void resetDrawnCards()
    {
      teller = 0;
    }

    public int getCardValue(string card, int currentTotal)
    {
      string lastChar = card.Substring(card.Length - 1, 1);

      switch (lastChar)
      {
        case "2":
          return 2;
        case "3":
          return 3;
        case "4":
          return 4;
        case "5":
          return 5;
        case "6":
          return 6;
        case "7":
          return 7;
        case "8":
          return 8;
        case "9":
          return 9;
        case "0":
          return 10;
        case "J":
          return 10; ;
        case "Q":
          return 10;
        case "K":
          return 10;
        case "A":
          return 11;
        default:
          Console.WriteLine("Oops! Something went wrong ;(");
          return 0;
      }
    }
  }
}
