using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_game
{
  public partial class CardDeckView : UserControl
  {
    CardDeckController _cardDeckController;

    public CardDeckView(CardDeckController _controller)
    {
      _cardDeckController = _controller;
      InitializeComponent();
    }

    private void CardDeckView_Load(object sender, EventArgs e)
    {

    }

    private void btnDrawCard_Click(object sender, EventArgs e)
    {
      Console.WriteLine(_cardDeckController.getCardValue(_cardDeckController.getRandomCard(), 0));
    }

    private void btnStop_Click(object sender, EventArgs e)
    {

    }
  }
}

