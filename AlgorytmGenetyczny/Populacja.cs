using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmGenetyczny
{
    class Populacja
    {
        int wielkoscPopulacji;
        int liczbaPokolen;
        List<Osobnik> populacja;

        public Populacja(int wielkosc = 100, int liczbaEpok = 10) //domyslne wartosci dla populacji
        {
            this.wielkoscPopulacji = wielkosc;
            this.liczbaPokolen = liczbaEpok;
        }

        public void symulujPokolenie(Selekcja metodaSelekcji, Krzyzowanie metodaKrzyzowania, Mutacja metodaMutacji )
        {
            List<Osobnik> nowePokolenie = dokonajSelekcji(metodaSelekcji);
            nowePokolenie = dokonajKrzyzowki(nowePokolenie, metodaKrzyzowania);
            nowePokolenie = dokonajMutacji(nowePokolenie, metodaMutacji);
    
        }

        private List<Osobnik> dokonajMutacji(List<Osobnik> nowePokolenie, Mutacja metodaMutacji)
        {
            throw new NotImplementedException();
        }

        private List<Osobnik> dokonajKrzyzowki(List<Osobnik> nowePokolenie, Krzyzowanie metodaKrzyzowania)
        {
            throw new NotImplementedException();
        }

        private List<Osobnik> dokonajSelekcji(Selekcja metodaSelekcji)
        {
            List<Osobnik> nowyZbior = new List<Osobnik>();
            foreach (Osobnik os in populacja)
            {
                //sprawdz osobnika, jesli przetrwal to dodaj do nowej populacji
                if (metodaSelekcji.sprawdz(os)) //zwraca bool
                {
                    nowyZbior.Add(os);
                }
            }
            return nowyZbior;
        }

        public List<Osobnik> Populacja { get; set; }
    }
}
