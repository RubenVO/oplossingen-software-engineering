using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YahtzeeTeerling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int aantalTeerlingen = 5;
            bool oneButtonIsShown = false;

            List<teerlingController> teerlingen = new List<teerlingController>();

            for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
            {
                if (aantalTeerlingen >= 2)
                {
                    oneButtonIsShown = true;
                }
                teerlingController nieuweTeerling = new teerlingController(oneButtonIsShown);
                teerlingen.Add(nieuweTeerling);
            }

            for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
            {

                teerlingController huidigeTeerling = teerlingen[teerlingNummer];

                TeerlingView huidigeTeerlingview = huidigeTeerling.getView();

                Controls.Add(huidigeTeerling.getView());

                int xPos = huidigeTeerlingview.Width * teerlingNummer;

                huidigeTeerlingview.Location = new Point(xPos, 0);
            }

            if (oneButtonIsShown)
            {
                scoreController scoreControl = new scoreController(teerlingen);
                scoreView ScoreView = scoreControl.getView();
                Controls.Add(ScoreView);
                ScoreView.Location = new Point(270, 205);

                allemaalController allemaalWerpenController = new allemaalController(teerlingen, scoreControl);
                allemaalView allemaalWerpenView = allemaalWerpenController.getView();
                Controls.Add(allemaalWerpenView);
                allemaalWerpenView.Location = new Point(50,200);
            }

        }


    }
}
