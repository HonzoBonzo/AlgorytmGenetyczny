using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorytmGenetyczny
{
    class Mutacja
    {

        private Osobnik zmutujOsobnika(Osobnik osobnik) {
            Osobnik zmutowany = osobnik.mutacja(); //mutacja zalezy od pol danych Osobnika, dlatego dalem ja do osobnika, a nie mutuje tutaj
            return zmutowany;
        }

        internal List<Osobnik> dokonajMutacji(List<Osobnik> populacja)
        {
            List<Osobnik> zmutowanaPopulacja = new List<Osobnik>();
            foreach (Osobnik os in populacja)
            {
                Osobnik zmutowany = zmutujOsobnika(os);
                zmutowanaPopulacja.Add(zmutowany);
            }
            return zmutowanaPopulacja;
        }
    }
}
