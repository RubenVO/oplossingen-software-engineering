using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    public class PlayerController
    {
        PlayerView _playerView;
        public PlayerModel _playerModel;
        public DealerController _dealerController;

        public PlayerController(DealerController _dController)
        {
            _playerView = new PlayerView(this);
            _playerModel = new PlayerModel();
            _dealerController = _dController;
        }


        public PlayerView getView()
        {
            return _playerView;
        }

        public void updateMoney()
        {
            _playerView._lblMoney.Text = "Money: " + _playerModel.CurrentMoney.ToString();
        }

        public void updateKaarten()
        {
            _playerView._lblKaarten.Text = "Kaarten: " + getRandomCard("player");
        }

        public void drawPlayerHand()
        {
            for (int counter = 0; counter < 2; counter++)
            {
                _playerModel.CurrentPlayerHand[counter] = getRandomCard("player");
            }
        }

        public void drawDealerHand()
        {
            for (int counter = 0; counter < 2; counter++)
            {
                _dealerController._dealerModel.DealerHand[counter] = getRandomCard("dealer");
            }
        }

        public string[] shuffle()
        {
            Random rnd = new Random();
            _playerModel.ArrCards = _playerModel.ArrCards.OrderBy(x => rnd.Next()).ToArray();
            return _playerModel.ShuffledDeck;
        }

        public string getRandomCard(string turn)
        {
            string drawCard = _playerModel.ArrCards[_playerModel.Teller];
            Console.WriteLine(drawCard);
            getCardValue(drawCard, turn);

            if (turn == "dealer")
            {
                bustCheck(_playerModel.CurrentDealerTotal, turn);
            }

            if (turn == "player")
            {
                bustCheck(_playerModel.CurrentPlayerTotal, turn);
            }

            _playerModel.Teller++;
            return drawCard;
        }

        public void resetDrawnCards()
        {
            _playerModel.Teller = 0;
        }

        public void getCardValue(string card, string turn)
        {
            string lastChar = card.Substring(card.Length - 1, 1);

            switch (lastChar)
            {
                case "2":
                    addCurrentTotal(2, turn);
                    break;
                case "3":
                    addCurrentTotal(3, turn);
                    break;
                case "4":
                    addCurrentTotal(4, turn);
                    break;
                case "5":
                    addCurrentTotal(5, turn);
                    break;
                case "6":
                    addCurrentTotal(6, turn);
                    break;
                case "7":
                    addCurrentTotal(7, turn);
                    break;
                case "8":
                    addCurrentTotal(8, turn);
                    break;
                case "9":
                    addCurrentTotal(9, turn);
                    break;
                case "0":
                    addCurrentTotal(10, turn);
                    break;
                case "J":
                    addCurrentTotal(10, turn);
                    break;
                case "Q":
                    addCurrentTotal(10, turn);
                    break;
                case "K":
                    addCurrentTotal(10, turn);
                    break;
                case "A":
                    if (turn == "dealer")
                    {
                        if (_playerModel.CurrentDealerTotal <= 10)
                        {
                            addCurrentTotal(11, turn);
                            _playerModel.ElevenCounter++;
                            break;
                        }
                        else
                        {
                            addCurrentTotal(1, turn);
                            break;
                        }
                    }
                    else
                    {
                        if (_playerModel.CurrentPlayerTotal <= 10)
                        {
                            addCurrentTotal(11, turn);
                            _playerModel.ElevenCounter++;
                            break;
                        }
                        else
                        {
                            addCurrentTotal(1, turn);
                            break;
                        }
                    };
                default:
                    Console.WriteLine("Oops! Something went wrong ;( en ruben is nog steeds lelijk");
                    break;
            }
        }

        public void addCurrentTotal(int addTotal, string turn)
        {
            if (turn == "dealer")
            {
                _playerModel.CurrentDealerTotal += addTotal;
            }

            if (turn == "player")
            {
                _playerModel.CurrentPlayerTotal += addTotal;
            }
        }

        public void bustCheck(int value, string turn)
        {
            if (turn == "dealer")
            {
                if (value > 21)
                {
                    if (_playerModel.ElevenCounter == 0)
                    {
                        Console.WriteLine("BUSTED NJIIIGAAAA");

                        Console.WriteLine(value);

                        _playerModel.DealerIsBust = true;
                    }
                    else
                    {
                        _playerModel.CurrentDealerTotal -= 10;
                        value -= 10;
                        _playerModel.ElevenCounter--;
                        bustCheck(value, "dealer");
                    }
                }
            }

            if (turn == "player")
            {
                if (value > 21)
                {
                    if (_playerModel.ElevenCounter == 0)
                    {
                        Console.WriteLine("BUSTED NJIIIGAAAA");

                        Console.WriteLine(value);

                        _playerModel.PlayerIsBust = true;

                        getView()._BtnDrawCard.Enabled = false;
                    }
                    else
                    {
                        _playerModel.CurrentPlayerTotal -= 10;
                        value -= 10;
                        _playerModel.ElevenCounter--;
                        bustCheck(value, "player");
                    }
                }
            }



            Console.WriteLine(value);
        }

        public void clearValues()
        {
            _playerModel.CurrentDealerTotal = 0;
            _playerModel.CurrentPlayerTotal = 0;

        }

        public void checkWinLose()
        {
            

            if ((_playerModel.CurrentPlayerTotal == _playerModel.CurrentDealerTotal) || (_playerModel.PlayerIsBust && _playerModel.DealerIsBust))
            {
                _playerModel.WinLose = "Draw!";
            }
            else if ((_playerModel.PlayerIsBust && !_playerModel.DealerIsBust) || ( (_playerModel.CurrentPlayerTotal < _playerModel.CurrentDealerTotal) && (!_playerModel.PlayerIsBust && !_playerModel.DealerIsBust)))
            {
                _playerModel.WinLose = "You Lose!";
            }
            else if ((!_playerModel.PlayerIsBust && _playerModel.DealerIsBust) || ( (_playerModel.CurrentPlayerTotal > _playerModel.CurrentDealerTotal) && (!_playerModel.PlayerIsBust && !_playerModel.DealerIsBust)))
            {
                _playerModel.WinLose = "You Win!";
                _playerModel.CurrentMoney += _playerModel.BettedMoney * 2; 
            }
            Console.Write(_playerModel.WinLose);

            getView()._lblWinLose.Text = _playerModel.WinLose;
            
        }



    }
}

