using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class scoreModel
    {

        int worpen = 0;
        int huidigeScore = 0;
        int highScore = 0;

        public int Worpen
        {
            get { return worpen; }
            set { worpen = value; }
        }

        public int HuidigeScore
        {
            get { return huidigeScore; }
            set { huidigeScore = value; }
        }

        public int HighScore
        {
            get { return highScore; }
            set { highScore = value; }
        }

    }
}
