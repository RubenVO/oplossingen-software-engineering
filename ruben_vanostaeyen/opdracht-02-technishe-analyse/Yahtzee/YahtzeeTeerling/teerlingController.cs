using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class teerlingController
    {
        TeerlingView _view;
        public teerlingModel _model;

        static int seeder = DateTime.Now.Second;
        Random random = new Random(++seeder); //zorgt ervoor dat random niet altijd hetzelfde is
        // random getallen zijn altijd 3 keer dezelfde


        public teerlingController(bool oneButtonIsShown) {
            _view = new TeerlingView(this, oneButtonIsShown);
            _model = new teerlingModel();
        }

        public TeerlingView getView() {

            return _view; 

        }

        public void werpTeerling() {
            if (!_model.IsVast)
            {
                
                int randomgetal = random.Next(1, 7);
                _model.AantalOgen = randomgetal;
                _view.updateLabel();
            }
           
        }

        public void toggleVast() {
            _model.IsVast = !_model.IsVast;

            updateVast();
        }

        public void updateVast() {
            if (_model.IsVast)
            {
                _view.TeerlingLabel.BackColor = Color.Red;
            }
            else
            {
                _view.TeerlingLabel.BackColor = Color.Transparent;
            }
        }

        public void resetVast()
        {
            _model.IsVast = false;
           

        }

        public void resetLabel()
        {
            _model.AantalOgen = 0;
            _view.updateLabel();


        }



    }
}
