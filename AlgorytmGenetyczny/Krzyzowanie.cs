using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorytmGenetyczny
{
    class Krzyzowanie
    {
        private Osobnik krzyzuj(Osobnik ojciec, Osobnik matka)
        {
            Osobnik dziecko = new Dziecko(ojciec,matka);
            return dziecko;
        }


        virtual internal List<Osobnik> dokonajKrzyzowki(List<Osobnik> pokolenie) // jakas domyslna krzyzowka dubluje Osobnikow np
        {
            List<Osobnik> nowePokolenie = new List<Osobnik>();
            foreach (Osobnik os in pokolenie)
            {
                nowePokolenie.Add(os);
                nowePokolenie.Add(os);
            }
            return nowePokolenie;
        }
    }
}
