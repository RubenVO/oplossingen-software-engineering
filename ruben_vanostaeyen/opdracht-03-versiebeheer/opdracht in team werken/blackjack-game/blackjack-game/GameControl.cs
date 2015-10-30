using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_game
{
    public partial class GameControl : Form
    {
        //bool isPlayerTurn = true;
        PlayerController player1;
        //CardDeckController cards;
        StartResetController startReset;
        PlayerBetController bet;
        DealerController dealer;
        

        public GameControl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //init
            //cards = new CardDeckController();
            dealer = new DealerController();
            player1 = new PlayerController(dealer);
            bet = new PlayerBetController(player1);
            startReset = new StartResetController(player1, bet, dealer);
            
            //add
            Controls.Add(player1.getView());
            Controls.Add(bet.getView());
            Controls.Add(startReset.getView());
            //Controls.Add(cards.getView());
            Controls.Add(dealer.getView());

            //pos for bet view
            int yPosBet = 0;
            yPosBet = player1.getView().Height;
            bet.getView().Location = new Point(0, yPosBet);

            //pos for start reset view
            int xPosStart = 0;
            xPosStart = player1.getView().Width;
            startReset.getView().Location = new Point(xPosStart + 50, 0);

            //pos for dealer
            int xPosDealer = 0;
            xPosDealer = player1.getView().Width + startReset.getView().Width;
            dealer.getView().Location = new Point(xPosDealer + 80, 0);
        }
    }
}
