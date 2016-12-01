using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorytmGenetyczny
{
    class Selekcja
    {
        int progPrzetrwania;

        public Selekcja(int prog = 50)
        {
            this.progPrzetrwania = prog;
        }

        virtual internal bool sprawdz(Osobnik osobnik)
        {
            if (osobnik.SilaPrzetrwania > progPrzetrwania) //przykladowa, domyslna selekcja
                return true;
            else
                return false;
        }

        internal List<Osobnik> dokonajSelekcji(List<Osobnik> populacja)
        {
            List<Osobnik> nowyZbior = new List<Osobnik>();
            foreach (Osobnik os in populacja)
            {
                //sprawdz osobnika, jesli przetrwal to dodaj do nowej populacji
                if (sprawdz(os)) //zwraca bool
                {
                    nowyZbior.Add(os);
                }
            }
            return nowyZbior;
        }

    }
}
