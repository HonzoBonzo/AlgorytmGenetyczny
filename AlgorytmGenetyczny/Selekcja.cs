using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorytmGenetyczny
{
    class Selekcja
    {
        virtual internal bool sprawdz(Osobnik osobnik)
        {
            if (osobnik.SilaPrzetrwania > 50) //przykladowa, domyslna selekcja
                return true;
            else
                return false;
        }
    }
}
