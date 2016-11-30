using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorytmGenetyczny
{
    class Osobnik
    {
        // slownik, np: {'imie' : 'Jan', 'wiek':'21'}
        Dictionary<string, string> dane; 
        // posluzy do krzyzowania
        int silaPrzetrwania; //wartosc od 0 - 100 %
        int chromosom;

        public Osobnik(Dictionary<string,string> dane) {
            this.dane = dane;
            przetworzDane();
            stworzChromosom();
        }

        void stworzChromosom(){
            Console.WriteLine("Tworze chromosom");
            //tutaj jakies dzialania na danych z ktorych tworzy sie chromosom, np jakas wartosc binarna
        }

        void przetworzDane(){
            //tutaj jakies dzialania na osobniku
            //na przyklad dla miast obliczenie odleglosci pomiedzy nimi
            //czyli np jakis foreach po Dict <s,s> dane ktory dodaje nowy klucz,wartosc
        }

        void ocenSilePrzetrwania(){
            Random rnd = new Random();
            var sila = rnd.Next(0, 100);
            this.silaPrzetrwania = sila;
        }
        public int SilaPrzetrwania { get; set; }    

    }


}
