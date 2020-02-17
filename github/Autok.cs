using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github
{
    class Autok
    {
        private List<Autok> lista;
      
            private string _marka;
            private string _modell;
            private int _evjarat;
            private int _kilometer;
            private string _uzemanyag;
            private int _ar;

        public override string ToString()
        {
            return (_marka + " " + _modell + " " + _evjarat + " " + _kilometer + " " + _uzemanyag + " " + _ar);
        }

        public Autok(string marka, string modell, int evjarat, int kilometer, string uzemanyag, int ar)
        {
            _marka = marka;
            _modell = modell;
            _evjarat = evjarat;
            _kilometer = kilometer;
            _uzemanyag = uzemanyag;
            _ar = ar;
        }

    }
}

