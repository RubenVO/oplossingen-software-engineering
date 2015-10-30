using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    public class DealerModel
    {
        string[] dealerHand = new string[11];

        public string[] DealerHand
        {
            get { return dealerHand; }
            set { dealerHand = value; }
        }
    }
}
