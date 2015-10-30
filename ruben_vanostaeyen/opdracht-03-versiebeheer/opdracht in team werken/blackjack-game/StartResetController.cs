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
        public CardDeckController _cardDeckController;
        public StartResetModel _startResetModel;
        public PlayerController _playerController;

        public StartResetController(CardDeckController _cdController, PlayerController _pController)
        {
            _cardDeckController = _cdController;
            _startResetView = new StartResetView(this);
            _startResetModel = new StartResetModel();
            _playerController = _pController;
        }

        public StartResetView getView()
        {
            return _startResetView;
        }

        public void StartGame(Button start)
        {
            _startResetModel.GameStarted = true;
            start.Visible = false; 
        }

        public void ResetGame(Button start)
        {
            if (start.Visible == true)
            {
                return;
            }
            else
            {
                _startResetModel.GameStarted = false;
                start.Visible = true;
                _cardDeckController.resetDrawnCards();
            }
        }
    }
}
