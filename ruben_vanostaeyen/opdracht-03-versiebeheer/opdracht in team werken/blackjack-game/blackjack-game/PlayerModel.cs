using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    public class PlayerModel
    {

        string winLose = "There is no winner";
        int currentMoney = 1000;
        string[] currentPlayerHand = new string[11];

        string[] arrCards = { "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H10", "HJ", "HQ", "HK", "HA",
                          "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S10", "SJ", "SQ", "SK", "SA",
                          "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "R10", "RJ", "RQ", "RK", "RA",
                          "K2", "K3", "K4", "K5", "K6", "K7", "K8", "K9", "K10", "KJ", "KQ", "KK", "KA"};
        string[] shuffledDeck;

        int teller = 0;
        int elevenCounter = 0;
        int totalValue = 0;
        static int currentPlayerTotal = 0;
        static int currentDealerTotal = 0;

        bool playerIsBust = false;
        bool dealerIsBust = false;

        int bettedMoney;
        int moneyInPot;

        public int BettedMoney
        {
            get
            {
                return bettedMoney;
            }
            set
            {
                bettedMoney = value;
            }
        }

        public int MoneyInPot
        {
            get
            {
                return moneyInPot;
            }
            set
            {
                moneyInPot = value;
            }
        }


        public int CurrentMoney
        {
            get
            {
                return currentMoney;
            }   
            set
            {
                currentMoney = value;
            }
        }

        public string[] CurrentPlayerHand
        {
            get
            {
                return currentPlayerHand;
            }
            set
            {
                currentPlayerHand = value;
            }
        }

       
        public string[] ArrCards
        {
            get { return arrCards; }
            set { arrCards = value; }
        }

        public string[] ShuffledDeck
        {
            get { return shuffledDeck; }
            set { shuffledDeck = value; }
        }

        public int Teller
        {
            get { return teller; }
            set { teller = value; }
        }

        public int ElevenCounter
        {
            get { return elevenCounter; }
            set { elevenCounter = value; }
        }

        public int TotalValue
        {
            get { return totalValue; }
            set { totalValue = value; }
        }

        public int CurrentPlayerTotal
        {
            get { return currentPlayerTotal; }
            set { currentPlayerTotal = value; }
        }

        public int CurrentDealerTotal
        {
            get { return currentDealerTotal; }
            set { currentDealerTotal = value; }
        }

        public bool PlayerIsBust
        {
            get { return playerIsBust; }
            set { playerIsBust = value; }
        }

        public bool DealerIsBust
        {
            get { return dealerIsBust; }
            set { dealerIsBust = value; }
        }

        public string WinLose
        {
            get { return winLose;  }
            set { winLose = value; }
        }

    }
}

