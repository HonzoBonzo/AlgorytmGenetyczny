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
        Selekcja metodaSelekcji;
        Krzyzowanie metodaKrzyzowania;
        Mutacja metodaMutacji;


        public Populacja(Selekcja s, Krzyzowanie k, Mutacja m, int wielkosc = 100, int liczbaEpok = 10) //domyslne wartosci dla populacji
        {
            this.metodaSelekcji = s;
            this.metodaKrzyzowania = k;
            this.metodaMutacji = m;
            this.wielkoscPopulacji = wielkosc;
            this.liczbaPokolen = liczbaEpok;
            populacja = losujPopulacje(wielkosc);
        }

        private List<Osobnik> losujPopulacje(int wielkosc)
        {
            List<Osobnik> pierwszaPopulacja = new List<Osobnik>();
            for (int i = 0; i < wielkosc; i++)
            {
                pierwszaPopulacja.Add(new Osobnik());
            }
            return pierwszaPopulacja;
        }

        public void symulujPokolenie()
        {
            List<Osobnik> nowePokolenie = metodaSelekcji.dokonajSelekcji(populacja);
            nowePokolenie = metodaKrzyzowania.dokonajKrzyzowki(nowePokolenie);
            nowePokolenie = metodaMutacji.dokonajMutacji(nowePokolenie);
    
        }


        private List<Osobnik> dokonajKrzyzowki(List<Osobnik> nowePokolenie, Krzyzowanie metodaKrzyzowania)
        {
            throw new NotImplementedException();
        }

        private List<Osobnik> dokonajMutacji(List<Osobnik> nowePokolenie, Mutacja metodaMutacji)
        {
            throw new NotImplementedException();
        }

        public List<Osobnik> Populacja { get; set; }
    }
}
