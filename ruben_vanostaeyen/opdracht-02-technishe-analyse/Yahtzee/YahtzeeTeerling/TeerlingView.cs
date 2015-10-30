using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class TeerlingView : UserControl
    {

        teerlingController _controller;
        bool _oneButtonShown;

        public Label TeerlingLabel{
            get { return teerlingLabel; }
            set { teerlingLabel = value; }
            }

        public TeerlingView(teerlingController controller, bool oneButtonShown)
        {
            _controller = controller;
            _oneButtonShown = oneButtonShown;
            InitializeComponent();
        }


        public void updateLabel() {
            teerlingLabel.Text = _controller._model.AantalOgen.ToString();
        }
    

        private void werpButton_Click(object sender, EventArgs e)
        {
            _controller.werpTeerling();
            updateLabel();
            

            
        }

        private void TeerlingView_Load(object sender, EventArgs e)
        {
            if (_oneButtonShown)
            {
                werpButton.Visible = false;
            }
            else
            {
                werpButton.Visible = true;
            }
        }

        private void teerlingLabel_Click(object sender, EventArgs e)
        {
            _controller.toggleVast();

        }
    }
}
