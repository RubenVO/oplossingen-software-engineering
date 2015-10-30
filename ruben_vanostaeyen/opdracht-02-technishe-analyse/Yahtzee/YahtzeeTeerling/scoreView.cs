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
    public partial class scoreView : UserControl
    {
        scoreController _controller;

        public Label WorpenLabel {
            get { return label1; }
            set { label1 = value; }
        }

        public Label HuidigeScoreLabel
        {
            get { return label2; }
            set { label2 = value; }
        }

        public Label HighScoreLabel
        {
            get { return label3; }
            set { label3 = value; }
        }

        public Button OpnieuwButton
        {
            get { return button1; }
            set { button1 = value; }
        }

        public scoreView(scoreController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void scoreView_Load(object sender, EventArgs e)
        {
            _controller.updateWorpenLabel();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.resetGame();
            
        }
    }
}
