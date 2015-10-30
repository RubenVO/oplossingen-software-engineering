using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_game
{
    public class StartResetController
    {
        StartResetView _startResetView;
        
        public StartResetModel _startResetModel;
        public PlayerController _playerController;
        public PlayerBetController _playerBetController;
        public DealerController _dealerController;

        public StartResetController(PlayerController _pController, PlayerBetController _pbController, DealerController _dController)
        {
            _startResetView = new StartResetView(this);
            _startResetModel = new StartResetModel();
            _playerController = _pController;
            _playerBetController = _pbController;
            _dealerController = _dController;
        }

        public StartResetView getView()
        {
            return _startResetView;
        }

        void Clearlabels()
        {
            _playerController.getView()._lblMoney.Text = "Money: ";
            _playerController.getView()._lblKaarten.Text = "Kaarten: ";
        }
        
        public void StartGame(Button start)
        {
            //init
            string[] currentPlayerHand = _playerController._playerModel.CurrentPlayerHand;
            string[] currentDealerHand = _dealerController._dealerModel.DealerHand;
            int currentMoney = _playerController._playerModel.CurrentMoney;
            Clearlabels();
            

            //set vars at start
            start.Visible = false;
            //_playerController._playerModel.CurrentMoney = 1000;

            //display the vars in labels           
            _playerController.getView()._lblMoney.Text += currentMoney.ToString();


            for (int i = 0; i < currentPlayerHand.Length; i++)
            {
                _playerController.getView()._lblKaarten.Text += " " + currentPlayerHand[i];
            }

            for (int i = 0; i < currentDealerHand.Length; i++)
            {
                _dealerController.getView()._lblDealerCards.Text += " " + currentDealerHand[i];
            }
        }

        public void ResetGame(Button start)
        {
            if (start.Visible == true)
            {
                return;
            }
            else
            {
                _playerController.clearValues();
                //_playerController.getView()._lblMoney.Text = "Money: ";
                _playerController.getView()._lblKaarten.Text = "Kaarten: ";
                _dealerController.getView()._lblDealerCards.Text = "Dealer kaarten: ";
                start.Visible = true;
                _playerController.resetDrawnCards();
                //_playerController._playerModel.CurrentMoney = 1000;
                _playerBetController.getView()._lblMoneyInPot.Text = "Money in pot: ";
                _playerController._playerModel.BettedMoney = 0;
                _playerController._playerModel.MoneyInPot = 0;
            }
        }
    }
}
