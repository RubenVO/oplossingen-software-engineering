using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
   public class teerlingModel
    {
        int _aantalOgen;
        bool _isVast;

        public int AantalOgen {
            get { return _aantalOgen; }
            set { _aantalOgen = value; }
        }

        public bool IsVast
        {
            get { return _isVast; }
            set { _isVast = value; }
        }

    }
}
