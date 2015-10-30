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
    public partial class allemaalView : UserControl
    {

        allemaalController _allemaalWerpenController;
        List<teerlingController> _huidigeTeerlingen;


        public Button AllemaalButton {
            get { return allemaalButton; }
            set {}
        }

        public allemaalView(allemaalController controller, List<teerlingController> huidigeteerlingen)
        {
            _allemaalWerpenController = controller;
            _huidigeTeerlingen = huidigeteerlingen;
            InitializeComponent();
        }

        private void allemaalView_Load(object sender, EventArgs e)
        {

        }

        private void allemaalButton_Click(object sender, EventArgs e)
        {
            if (_allemaalWerpenController._scorecontrol._model.Worpen < 3)
            {
                foreach (teerlingController teerling in _huidigeTeerlingen)
                {
                    teerling.werpTeerling();


                }
                _allemaalWerpenController.checkAndUpdateWorpen();
                _allemaalWerpenController._scorecontrol.checkAndUpdateScore();
                _allemaalWerpenController._scorecontrol.updateWorpenLabel();
            }
            
            

        }
    }
}
