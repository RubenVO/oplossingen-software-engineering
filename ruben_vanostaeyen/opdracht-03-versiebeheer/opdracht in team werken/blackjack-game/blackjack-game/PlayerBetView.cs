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
    public partial class PlayerBetView : UserControl
    {
        PlayerBetController _playerBetController;

        public Button _btnBet 
        {
            get
            {
                return btnBet;
            }
            set
            {
                btnBet = value;
            }
        }

        public TextBox _txtBetMoney
        {
            get
            {
                return txtBetMoney;
            }
            set
            {
                txtBetMoney = value;
            }
        }

        public Label _lblMoneyInPot
        {
            get
            {
                return lblMoneyPot;
            }
            set
            {
                lblMoneyPot = value;
            }
        }



        public PlayerBetView(PlayerBetController _controller)
        {
            _playerBetController = _controller;
            InitializeComponent();
        }

        private void PlayerBetView_Load(object sender, EventArgs e)
        {
            _txtBetMoney.Enabled = false;
            _btnBet.Enabled = false;
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            int textBoxValue;
            if (int.TryParse(txtBetMoney.Text, out textBoxValue))
            {
                if (_playerBetController._playerController._playerModel.CurrentMoney >= int.Parse(txtBetMoney.Text) && int.Parse(txtBetMoney.Text) > 0)
                {
                    _playerBetController.Bet(txtBetMoney);
                    _playerBetController.putMoneyInPut(_lblMoneyInPot);
                    _playerBetController._playerController.getView()._BtnDrawCard.Enabled = true;
                    _playerBetController._playerController.getView()._BtnStop.Enabled = true;
                    _btnBet.Enabled = false;
                    _txtBetMoney.Enabled = false;
                    _txtBetMoney.Text = "";
                }
                else
                {
                    txtBetMoney.Text = "Not enough money!";
                    return;
                }
            }

            Console.WriteLine(_playerBetController._playerController._playerModel.CurrentMoney);
        }

        private void txtBetMoney_Click(object sender, EventArgs e)
        {
            _playerBetController.ClearTxtBox(txtBetMoney);
        }
    }
}
