using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorytmGenetyczny
{
    class Dziecko : Osobnik
    {
        private Osobnik ojciec;
        private Osobnik matka;

        public Dziecko(Osobnik ojciec, Osobnik matka)
        {
            this.ojciec = ojciec;
            this.matka = matka;
        }
    }
}
