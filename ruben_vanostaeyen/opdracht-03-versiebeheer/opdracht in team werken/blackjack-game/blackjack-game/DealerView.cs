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
    public partial class DealerView : UserControl
    {
        public Label _lblDealerCards {
            get { return lblDealerCards; }
            set { lblDealerCards = value; }
        }

        public DealerController _dealerController;

        public DealerView(DealerController _dcontroller)
        {
            _dealerController = _dcontroller;
            InitializeComponent();
        }

        private void lblDealerCards_Click(object sender, EventArgs e)
        {

        }

        private void DealerView_Load(object sender, EventArgs e)
        {

        }
    }
}
