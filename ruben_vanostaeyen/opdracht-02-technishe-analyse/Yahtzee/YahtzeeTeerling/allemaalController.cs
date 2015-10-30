using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{

    public class allemaalController
    {
        
        allemaalView _view;
        public allemaalModel _model;
        public scoreController _scorecontrol;
        
        
        

        public allemaalController(List<teerlingController> huidigeteerlingen, scoreController scoreControl) {

            _view = new allemaalView(this, huidigeteerlingen);
            _model = new allemaalModel();
            _scorecontrol = scoreControl;
     
        }

        public allemaalView getView()
        {

            return _view;

        }

        public void checkAndUpdateWorpen()
        {
            if (_scorecontrol._model.Worpen > 1)
            {
                _scorecontrol._model.Worpen++;
                _scorecontrol.updateOpnieuwButton(true);
            }
            else {
                _scorecontrol._model.Worpen++;

            }

          
        }



    }
}
