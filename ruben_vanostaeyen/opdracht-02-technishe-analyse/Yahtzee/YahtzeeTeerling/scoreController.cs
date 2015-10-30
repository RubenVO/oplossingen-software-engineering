using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class scoreController
    {

        scoreView _view;
        public scoreModel _model;
        List<teerlingController> _teerlingen;

        public scoreController(List<teerlingController> teerlingen)
        {
            _view = new scoreView(this);
            _model = new scoreModel();
            _teerlingen = teerlingen;
        }

        public scoreView getView()
        {

            return _view;

        }

        public void updateWorpenLabel()
        {

            _view.WorpenLabel.Text = "Aantal worpen: " + _model.Worpen + "/3";
        }

        public void updateScoreLabels()
        {

            _view.HuidigeScoreLabel.Text = "Huidige score: " + _model.HuidigeScore;
            _view.HighScoreLabel.Text = "Hoogste score: " + _model.HighScore;
        }

        public void updateOpnieuwButton(bool isVisible)
        {
            _view.OpnieuwButton.Visible = isVisible;
        }

        public void resetGame() {
            foreach (teerlingController teerling in _teerlingen)
            {
                teerling.resetLabel();
                teerling.resetVast();
                teerling.updateVast();
                _model.Worpen = 0;
                _model.HuidigeScore = 0;
                updateScoreLabels();
                updateWorpenLabel();
                updateOpnieuwButton(true);
                               
                _view.OpnieuwButton.Visible = false;
                
            }
        }

        public void checkAndUpdateScore() {
            _model.HuidigeScore = 0;
            foreach (teerlingController teerling in _teerlingen)
            {
                _model.HuidigeScore += teerling._model.AantalOgen;

            }
            if (_model.HighScore < _model.HuidigeScore)
            {
                _model.HighScore = _model.HuidigeScore;
            }

            updateScoreLabels();
        }




    }
}
