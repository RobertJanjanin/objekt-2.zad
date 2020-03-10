using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statickeMetodeRobertJanjanin
{
    class PrvaKlasa
    {
        string ime;
        int godina;
        static int brojac;
        public string Ime { get => ime; set => ime = value; }
        public int Godina { get => godina; set => godina = value; }

        public PrvaKlasa(string ime, int godina)
        {
            brojac++;
            this.ime = ime;
            this.godina = godina;
        }
        public override string ToString()
        {
           string ispis = "\nIme: " + ime + "\nGodiste: " + godina + "\nRedni broj: " + brojac;
            return ispis;
        }
    }
}
