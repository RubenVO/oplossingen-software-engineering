using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_game
{
    public class PlayerBetController
    {
        PlayerBetView _playerBetView;
        public PlayerBetModel _playerBetModel;
        public PlayerController _playerController;
        
        public PlayerBetController(PlayerController _controller)
        {
            _playerBetView = new PlayerBetView(this);
            _playerBetModel = new PlayerBetModel();
            _playerController = _controller;
        } 
        
        public PlayerBetView getView()
        {
            return _playerBetView;
        }

        public void Bet(TextBox txtBox)
        {
            int betMoneyValue;

            if (txtBox.Text == "")
            {
                txtBox.Text = "Please put in a value!";
                return;
            }
            else
            {
                if (int.TryParse(txtBox.Text, out betMoneyValue))
                {
                    betMoneyValue = int.Parse(txtBox.Text);
                    _playerController._playerModel.MoneyInPot += betMoneyValue;
                    
                    if (betMoneyValue <= _playerController._playerModel.CurrentMoney)
                    {
                        _playerController._playerModel.BettedMoney = betMoneyValue;
                        _playerController._playerModel.CurrentMoney -= betMoneyValue;
                        _playerController.updateMoney();
                    }
                    
                }
            }
        }

        public void ClearTxtBox(TextBox txtBox)
        {
            txtBox.Clear();
        }

        public void putMoneyInPut(Label label)
        {
            label.Text = "Money in pot: " + _playerController._playerModel.MoneyInPot.ToString();
        }


    }
}
