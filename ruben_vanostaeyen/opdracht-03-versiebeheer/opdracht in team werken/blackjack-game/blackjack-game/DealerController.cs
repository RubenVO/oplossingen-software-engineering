using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    public class DealerController
    {
        public DealerModel _dealerModel;
        DealerView _dealerView;
        

        public DealerController()
        {
            _dealerModel = new DealerModel();
            _dealerView = new DealerView(this);
                      

        }

        public DealerView getView()
        {
            return _dealerView;
        }

        
    }
}