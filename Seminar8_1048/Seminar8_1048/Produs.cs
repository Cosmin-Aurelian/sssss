using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar8_1048
{
    class Produs
    {
        private string denumire;
        private int pret;
        private int cantitate;

        public Produs(string denumire, int pret, int cantitate)
        {
            this.denumire = denumire;
            this.pret = pret;
            this.cantitate = cantitate;
        }

        public string Denumire
        {
            get => denumire;
        }

        public int Pret
        {
            get => pret;
        }

        public int Cantitate
        {
            get => cantitate;
        }
    }
}
